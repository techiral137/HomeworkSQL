using System;
using System.Configuration;
using System.Text;
using System.Windows.Forms;

namespace HomeWorkSQL
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            ServerTextBox.Text = ConfigurationManager.AppSettings["Server"];
            DataBaseTextBox.Text = ConfigurationManager.AppSettings["Database"];
            UIDTextBox.Text = ConfigurationManager.AppSettings["Uid"];
            PassWordTextBox.Text = ConfigurationManager.AppSettings["Password"];
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ServerTextBox.Text) && !string.IsNullOrEmpty(DataBaseTextBox.Text)
                && !string.IsNullOrEmpty(UIDTextBox.Text) && !string.IsNullOrEmpty(PassWordTextBox.Text))
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Server"].Value = ServerTextBox.Text;
                config.AppSettings.Settings["Database"].Value = DataBaseTextBox.Text;
                config.AppSettings.Settings["UID"].Value = UIDTextBox.Text;
                config.AppSettings.Settings["Password"].Value = PassWordTextBox.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                MessageBox.Show("값이 App.config에 저장되었습니다.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                string errorMessage = ConfigEmptyCheck(string.IsNullOrEmpty(ServerTextBox.Text),
                    string.IsNullOrEmpty(DataBaseTextBox.Text)
                    , string.IsNullOrEmpty(UIDTextBox.Text), string.IsNullOrEmpty(PassWordTextBox.Text));
                MessageBox.Show(errorMessage + " \nFill in the Blank","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private string ConfigEmptyCheck(bool ServerEmpty, bool DataBaseEmpty, bool UIDEmpty, bool PasswordEmpty)
        {
            StringBuilder emptyFields = new StringBuilder();
            if (ServerEmpty)
            {
                if (emptyFields.Length > 0)
                    emptyFields.Append(", ");
                emptyFields.Append("Server");
            }
            if (DataBaseEmpty)
            {
                if (emptyFields.Length > 0)
                    emptyFields.Append(", ");
                emptyFields.Append("Database");
            }
            if (UIDEmpty)
            {
                if (emptyFields.Length > 0)
                    emptyFields.Append(", ");
                emptyFields.Append("UID");
            }
            if (PasswordEmpty)
            {
                if (emptyFields.Length > 0)
                    emptyFields.Append(", ");
                emptyFields.Append("Password");
            }
            emptyFields.Append(" is Empty");
            return emptyFields.Length > 0 ? emptyFields.ToString() : null;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
