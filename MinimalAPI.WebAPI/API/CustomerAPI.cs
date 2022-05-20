namespace MinimalAPI.WebAPI.API;

public static class CustomerAPI
{
    public static void ConfigureCustomerAPI(this WebApplication app)
    {
        // All of the API endpoints mapping
        app.Map("/GetCustomer/{customerID}", GetCustomer).WithName("Get");
        app.Map("/GetCustomers", GetCustomers).WithName("Get");
        app.Map("/DeleteCustomer/{customerID}", DeleteCustomer).WithName("Delete");
        app.Map("/UpdateCustomer", UpdateCustomer).WithName("Update");
        app.Map("/CreateCustomer", CreateCustomer).WithName("Create");
    }

    private static async Task<IResult> GetCustomer(ICustomerRepository repository, int customerID)
    {
        try
        {
            var result = await repository.GetCustomer(customerID);
            return Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetCustomers(ICustomerRepository repository)
    {
        try
        {
            var result = await repository.GetCustomers();
            return Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteCustomer(ICustomerRepository repository, int customerID)
    {
        try
        {
            await repository.DeleteCustomer(customerID);
            return Results.Ok("Customer was successfully deleted");
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateCustomer(ICustomerRepository repository, CustomerModel customer)
    {
        try
        {
            await repository.UpdateCustomer(customer);
            return Results.Ok("Customer was successfully updated");
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> CreateCustomer(ICustomerRepository repository, CustomerModel customer)
    {
        try
        {
            await repository.CreateCustomer(customer);
            return Results.Ok("Customer was successfully created");
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
