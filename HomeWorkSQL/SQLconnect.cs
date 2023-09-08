using System.Configuration;
using System.Data.SqlClient;

namespace HomeWorkSQL
{
    class SQLconnect
    {
        public SqlConnection getConnection()
        {
            string serverName = ConfigurationManager.AppSettings["Server"];
            string databaseName = ConfigurationManager.AppSettings["Database"];
            string uid = ConfigurationManager.AppSettings["Uid"];
            string password = ConfigurationManager.AppSettings["Password"];
            string connectionSTR = $"Server={serverName};Database={databaseName};User ID={uid};Password={password};";
            SqlConnection conn = new SqlConnection(connectionSTR);
            return conn;
        }
    }
}