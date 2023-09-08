using System.Data.SqlClient;

namespace HomeWorkSQL
{
    class SqlDataUpdate
    {
        public void sqlDataUpdate(int id ,string name, string birthday, string job, bool marry)
        {
            SQLconnect connection = new SQLconnect();
            SqlConnection conn = connection.getConnection();
            SqlCommand sqlAddCommand = new SqlCommand();
            conn.Open();
            sqlAddCommand.Connection = conn;
            sqlAddCommand.CommandText = $"Update AccountInfo set ID = @id ,Name = @name,Birthday = @birthday,Job = @job,Marry = @marry WHERE ID = {id}";
            sqlAddCommand.Parameters.AddWithValue("@id", id);
            sqlAddCommand.Parameters.AddWithValue("@name", name);
            sqlAddCommand.Parameters.AddWithValue("@birthday", birthday);
            sqlAddCommand.Parameters.AddWithValue("@job", job);
            sqlAddCommand.Parameters.AddWithValue("@marry", marry);
            sqlAddCommand.ExecuteNonQuery();
        }
    }
}
