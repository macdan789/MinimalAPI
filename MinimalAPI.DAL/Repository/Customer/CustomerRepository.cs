using MinimalAPI.DAL.Model.Customer;
using MinimalAPI.DAL.SqlAgent;

namespace MinimalAPI.DAL.Repository.Customer;

public class CustomerRepository : ICustomerRepository
{
    private ISqlAgent SqlAgent { get; }

    public CustomerRepository(ISqlAgent sqlAgent)
    {
        SqlAgent = sqlAgent;
    }

    public async Task<CustomerModel> GetCustomer(int customerID)
    {
        var result = await SqlAgent.LoadData<CustomerModel, object>("[dbo].[GetCustomer]", new { CustomerID = customerID });

        return result.FirstOrDefault();
    }

    public async Task<IEnumerable<CustomerModel>> GetCustomers()
        => await SqlAgent.LoadData<CustomerModel, object>("[dbo].[GetCustomers]", new { });

    public async Task DeleteCustomer(int customerID)
        => await SqlAgent.SaveData<CustomerModel, object>("[dbo].[DeleteCustomer]", new { CustomerID = customerID });

    public async Task UpdateCustomer(CustomerModel customer)
        => await SqlAgent.SaveData<CustomerModel, object>("[dbo].[UpdateCustomer]",
            new
            {
                customer.CustomerID,
                customer.FirstName,
                customer.LastName,
                customer.EmailAddress
            });

    public async Task CreateCustomer(CustomerModel customer)
    => await SqlAgent.SaveData<CustomerModel, object>("[dbo].[CreateCustomer]",
        new
        {
            customer.FirstName,
            customer.LastName,
            customer.EmailAddress
        });
}
