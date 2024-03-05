using System.Data;
using Microsoft.Extensions.Options;
using Npgsql;

namespace Customer.Api.Database;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}

public class NpgSqlConnectionFactory : IDbConnectionFactory
{
    private readonly ConnectionOptions _opt;
    
    public NpgSqlConnectionFactory(IOptions<ConnectionOptions> connect)
    {
        _opt = connect.Value;
    }
    
    public IDbConnection CreateConnection() => new NpgsqlConnection(_opt.CustomerDB);
}