namespace MinimalAPI.DAL.SqlAgent.Customer
{
    public interface ICustomerSqlAgent
    {
        Task<IEnumerable<TResult>> LoadData<TResult, TParam>(string procedure, TParam parameters, string connectionType = "Default");
        Task SaveData<TResult, TParam>(string procedure, TParam parameters, string connectionType = "Default");
    }
}