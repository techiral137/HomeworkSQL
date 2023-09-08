using System.Data.SqlClient;

namespace HomeWorkSQL
{
    class SqlDataDelete
    {
        public void delete(int id)
        {
            SQLconnect connection = new SQLconnect();
            SqlConnection conn = connection.getConnection();
            SqlCommand sqlAddCommand = new SqlCommand();
            conn.Open();
            sqlAddCommand.Connection = conn;
            sqlAddCommand.CommandText = "DELETE FROM AccountInfo WHERE ID = @id";
            sqlAddCommand.Parameters.AddWithValue("@Id", id);
            sqlAddCommand.ExecuteNonQuery();
        }
    }
}
