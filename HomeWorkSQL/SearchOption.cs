using System.Data.SqlClient;
using System.Data;
using System;
using System.Text;
using System.Xml.Linq;

namespace HomeWorkSQL
{
    class SearchOption
    {
        public enum SearchType
        {
            AllData,
            Birthday,
            ID,
            Job,
            Name
        }
        public string FilterSearchQuery(SearchType searchType, string searchWord)
        { 
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT * FROM AccountInfo WHERE 1=1");//데이터 참 확인 문 
            if (!string.IsNullOrEmpty(searchWord))
            {
                switch (searchType)
              {
                case SearchType.AllData:
                  stringBuilder.Append($"AND (ID Like N'%{searchWord}%' " +
                                      $"OR Name Like N'%{searchWord}%' " +
                                      $"OR Job Like N'%{searchWord}%' " +
                                      $"OR Birthday Like N'%{searchWord}%' )");
                  break;
                case SearchType.Birthday:
                  stringBuilder.Append($"AND Birthday Like N'%{searchWord}%'");
                  break;
                case SearchType.ID:
                  stringBuilder.Append($"AND ID = {searchWord}");
                  break;
                case SearchType.Job:
                  stringBuilder.Append($"AND Job Like N'%{searchWord}%'");
                  break;
                case SearchType.Name:
                  stringBuilder.Append($"AND Name Like N'%{searchWord}%'");
                  break;
              }
            }
            return stringBuilder.ToString();
        }
        public DataTable DataOutput(string query)
        {
            SQLconnect connection = new SQLconnect();
            SqlConnection conn = connection.getConnection();
            SqlCommand command = new SqlCommand();
            conn.Open();
            command.Connection = conn;
            command.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
