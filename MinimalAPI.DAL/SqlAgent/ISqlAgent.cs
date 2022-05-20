namespace MinimalAPI.DAL.SqlAgent
{
    public interface ISqlAgent
    {
        Task<IEnumerable<TResult>> LoadData<TResult, TParam>(string procedure, TParam parameters, string connectionType = "Default");
        Task SaveData<TResult, TParam>(string procedure, TParam parameters, string connectionType = "Default");
    }
}