using Customer.Api.Models;
using Customer.Api.Repositories;

namespace Customer.Api.Services;

public interface ICustomerService
{
    Task<CustomerDto[]> GetAll();
}

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    
    public async Task<CustomerDto[]> GetAll()
    {
        // todo change implementation
        var res = await _customerRepository.GetCustomers();
        return Array.Empty<CustomerDto>();
    }
}