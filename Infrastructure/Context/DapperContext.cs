using System.Data;
using Npgsql;

public class DapperContext
{
string connectionString="Server=localhost;Port=5432;Database=softclub;User Id=postgres;Password=4856;";
public DapperContext()
{
    
}
public IDbConnection CreateConnection(){
    return new NpgsqlConnection(connectionString);
}
}