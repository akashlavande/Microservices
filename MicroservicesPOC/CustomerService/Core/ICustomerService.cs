using CustomerService.Dto;
using CustomerService.Model;

namespace CustomerService.Core
{
    public interface ICustomerService
    {
        IList<Customer> GetAllCustomers();
        Customer GetCustomerById(Guid id);
        Customer CreateCustomer(CustomerDto request);
        void UpdateCustomer(Customer request);
        void DeleteCustomer(Guid id);
    }
}
