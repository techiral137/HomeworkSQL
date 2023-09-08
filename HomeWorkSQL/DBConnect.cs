using System.Data.SqlClient;
using System.Data;

namespace HomeWorkSQL
{
    class DBconnect
    {
        public DataSet GetData()
        {
            SQLconnect connection = new SQLconnect();
            SqlConnection conn = connection.getConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM AccountInfo ", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
    }
}
