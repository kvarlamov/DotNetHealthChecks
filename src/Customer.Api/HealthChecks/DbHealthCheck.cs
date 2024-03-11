using Customer.Api.Database;
using Dapper;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Customer.Api.HealthChecks;

public class DbHealthCheck : IHealthCheck
{
    private readonly IDbConnectionFactory _connectionFactory;

    public DbHealthCheck(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context, 
        CancellationToken cancellationToken = new())
    {
        try
        {
            using var conn = _connectionFactory.CreateConnection();
            var query = "SELECT 1";
            await conn.QueryAsync(query);
            return HealthCheckResult.Healthy();
        }
        catch (Exception e)
        {
            return HealthCheckResult.Unhealthy();
        }
    }
}