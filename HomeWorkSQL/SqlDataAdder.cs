using System.Data.SqlClient;

namespace HomeWorkSQL
{
    class SqlDataAdder
    {
        public void sqlAdder(int id ,string name,string birthday, string job, bool marry)
        {       
            SQLconnect connection = new SQLconnect();
            SqlConnection conn = connection.getConnection();
            SqlCommand sqlAddCommand = new SqlCommand();
            conn.Open();
            sqlAddCommand.Connection = conn;
            sqlAddCommand.CommandText = "insert into AccountInfo(Id,Name,Birthday,Job,Marry) " +
                $"values(@id, @name,@birthday,@job,@marry)";
            sqlAddCommand.Parameters.AddWithValue("@Id", id);
            sqlAddCommand.Parameters.AddWithValue("@name", name);
            sqlAddCommand.Parameters.AddWithValue("@birthday",birthday);
            sqlAddCommand.Parameters.AddWithValue("@job", job);
            sqlAddCommand.Parameters.AddWithValue("@marry", marry);
            sqlAddCommand.ExecuteNonQuery();
        }
    }
}
