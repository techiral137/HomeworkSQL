using System.Text;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System;

namespace HomeWorkSQL
{
    internal class Crptograpy
    {
        public void crptograpy(string password)
        {
            SQLconnect connection = new SQLconnect();
            SqlConnection conn = connection.getConnection();
            conn.Open();
            string crptorapiedPassword = crptorapyPassword(password);
            string extendData_query = $"ALTER TABLE AccountCheck ALTER COLUMN AccountPW varchar({crptorapiedPassword.Length+1}) NULL";
            string query = "UPDATE AccountCheck SET AccountPW = @PasswordHash";
            SqlCommand extendCommand = new SqlCommand(extendData_query,conn);
            SqlCommand updateCommand = new SqlCommand(query, conn);
            updateCommand.Parameters.AddWithValue("@PasswordHash", crptorapiedPassword);
            extendCommand.ExecuteNonQuery();
            updateCommand.ExecuteNonQuery();
        }
        public string crptorapyPassword(string password)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(bytes);
            string crptograpiedPassword =Convert.ToBase64String(hash);
            return crptograpiedPassword;
        }
    }
}
