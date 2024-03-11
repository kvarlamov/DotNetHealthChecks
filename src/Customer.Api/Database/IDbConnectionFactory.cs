using System.Data;

namespace Customer.Api.Database;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}