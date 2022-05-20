using MinimalAPI.DAL.Model.Customer;

namespace MinimalAPI.DAL.Repository.Customer
{
    public interface ICustomerRepository
    {
        Task CreateCustomer(CustomerModel customer);
        Task DeleteCustomer(int customerID);
        Task<CustomerModel> GetCustomer(int customerID);
        Task<IEnumerable<CustomerModel>> GetCustomers();
        Task UpdateCustomer(CustomerModel customer);
    }
}