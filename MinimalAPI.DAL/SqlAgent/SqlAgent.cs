using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MinimalAPI.DAL.SqlAgent;

public class SqlAgent : ISqlAgent
{
    private IConfiguration Configuration { get; }

    public SqlAgent(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public async Task<IEnumerable<TResult>> LoadData<TResult, TParam>(
        string procedure,
        TParam parameters,
        string connectionType = "Default")
    {
        using IDbConnection connection = new SqlConnection(Configuration.GetConnectionString(connectionType));

        return await connection.QueryAsync<TResult>(procedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task SaveData<TResult, TParam>(
        string procedure,
        TParam parameters,
        string connectionType = "Default")
    {
        using IDbConnection connection = new SqlConnection(Configuration.GetConnectionString(connectionType));

        //TODO:
        //return affected rows to check result of procedure execution
        await connection.ExecuteAsync(procedure, parameters, commandType: CommandType.StoredProcedure);
    }
}
