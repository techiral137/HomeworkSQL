using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HomeWorkSQL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            SQLconnect connection = new SQLconnect();
            Crptograpy crptograpy = new Crptograpy();
            try
            {
                var conn = connection.getConnection();
                conn.Open();
                bool Login = false;
                string Login_ID = textBox_ID.Text;
                string Login_PassWord = textBox_PassWord.Text;
                string sql = "SELECT * FROM AccountCheck where AccountID=@Login_ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Login_ID", Login_ID);
                SqlDataReader mdr = cmd.ExecuteReader();
                while (mdr.Read())
                {
                    if (((string)mdr["AccountPW"]).Length > textBox_PassWord.Text.Length)
                    {
                        Login_PassWord = crptograpy.crptorapyPassword(textBox_PassWord.Text);
                    }
                    if (Login_ID == (string)mdr["AccountID"] && Login_PassWord == (string)mdr["AccountPW"])
                    Login = true;
                }
                if (Login)
                {
                    this.Login_ID = textBox_ID.Text;
                    this.DialogResult = DialogResult.OK;
                    crptograpy.crptograpy(textBox_PassWord.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Check Your ID and Password!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Check your Database!! "+"\n"+ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
        }
        public string Login_ID
        {
            get;
            private set;
        }
        private void DBconnection_Click(object sender, EventArgs e)
        {
            SettingForm setting = new SettingForm();
            setting.ShowDialog();
        }
    }
}
