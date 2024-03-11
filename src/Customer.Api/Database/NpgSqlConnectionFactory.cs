using System.Data;
using Microsoft.Extensions.Options;
using Npgsql;

namespace Customer.Api.Database;

public class NpgSqlConnectionFactory : IDbConnectionFactory
{
    private readonly ConnectionOptions _opt;
    
    public NpgSqlConnectionFactory(IOptions<ConnectionOptions> connect)
    {
        _opt = connect.Value;
    }
    
    public IDbConnection CreateConnection() => new NpgsqlConnection(_opt.DockerConn);
}