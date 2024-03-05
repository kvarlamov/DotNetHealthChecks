using Customer.Api.Database;
using Dapper;

namespace Customer.Api.Repositories;

public interface ICustomerRepository
{
    Task<Database.Customer[]> GetCustomers();
}

public class CustomerRepository : ICustomerRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public CustomerRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }
    
    public async Task<Database.Customer[]> GetCustomers()
    {
        using var connection = _connectionFactory.CreateConnection();
        var query = @"select * from ""Customers""";

        var result = await connection.QueryAsync<Database.Customer>(query);
        return result.ToArray();
    }
}