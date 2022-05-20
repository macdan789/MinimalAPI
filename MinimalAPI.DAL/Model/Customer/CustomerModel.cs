namespace MinimalAPI.DAL.Model.Customer;

public class CustomerModel
{
    public int CustomerID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime CreatedAt { get; set; }
    public string EmailAddress { get; set; }

}
