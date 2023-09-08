using System;
using System.Data.SqlClient;

namespace HomeWorkSQL
{
    class IDisExist
    {
        public bool IdIsExist(int id)
        {
            SQLconnect connection = new SQLconnect();
            SqlConnection conn = connection.getConnection();
            SqlCommand command = new SqlCommand();
            conn.Open();
            string InputCmd = "IF EXISTS (SELECT ID FROM AccountInfo WHERE ID = @id) " +
                               "BEGIN " +
                               "   SELECT 'true' " +
                               "END " +
                               "ELSE " +
                               "BEGIN " +
                               "   SELECT 'false' " +
                               "END";
            //string InputCmd = "SELECT COUNT(*) FROM AccountInfo WHERE ID = @id "; // 방법 보완 필
            command.Connection = conn;
            command.CommandText = InputCmd;
            command.Parameters.AddWithValue("@Id", id);
            string obs = command.ExecuteScalar() as String;
            if(obs == "true"){return true;}
            else { return false;}
        }
    }
}
