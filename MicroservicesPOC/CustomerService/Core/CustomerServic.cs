using CustomerService.Dto;
using CustomerService.Model;

namespace CustomerService.Core
{
    public class CustomerServic : ICustomerService
    {
        private static List<Customer> CustomerList = new List<Customer>
        {
            new Customer{Id = Guid.Parse("78595bdb-c04d-4714-81a0-c120e755ddb8"), Name ="Simplifai India", Email = "hr-india@simplifai.ai", City = "Pune" },
            new Customer{Id = Guid.Parse("060fbd07-b78a-4266-b784-df157570acdd"), Name ="Simplifai Norway", Email = "hr-norway@simplifai.ai", City = "Oslo" }
        };

        public IList<Customer> GetAllCustomers()
        {
            return CustomerList;
        }

        public Customer GetCustomerById(Guid id)
        {
            return CustomerList.Find(c => c.Id.Equals(id));
        }

        public Customer CreateCustomer(CustomerDto request)
        {
            var newCustomer = new Customer
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                City = request.City
            };
            CustomerList.Add(newCustomer);
            return newCustomer;
        }

        public void UpdateCustomer(Customer request)
        {
            var existingCustomer = CustomerList.Find(c => c.Id.Equals(request.Id));
            if (existingCustomer is not null)
            {
                existingCustomer.Name = request.Name;
                existingCustomer.Email = request.Email;
                existingCustomer.City = request.City;
                return;
            }
            throw new Exception("Customer doesn't exist!");
        }

        public void DeleteCustomer(Guid id)
        {
            var existingCustomer = CustomerList.Find(c => c.Id.Equals(id));
            if (existingCustomer is not null)
            {
                CustomerList.Remove(existingCustomer);
                return;
            }
            throw new Exception("Customer doesn't exist!");
        }

    }
}
