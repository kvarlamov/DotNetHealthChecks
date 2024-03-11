namespace Customer.Api.Repositories;

public interface ICustomerRepository
{
    Task<Database.Customer[]> GetCustomers();
}