using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace HomeWorkSQL
{
    public partial class MemberManagement : Form
    {
        public MemberManagement()
        {
            InitializeComponent();
        }
        private void RegisterADD_Click(object sender, EventArgs e)
        {
            MemberRegister memberRegister = new MemberRegister();
            memberRegister.ShowDialog();
        }
        private void RegisterUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = RegisterInfoGrid.CurrentRow;
            if (row != null)
            {
              int id = Int32.Parse(row.Cells["ID"].Value.ToString());
              string name = row.Cells["Name"].Value.ToString();
              string birthDay = row.Cells["Birthday"].Value.ToString();
              string job = row.Cells["Job"].Value.ToString();
              object value = row.Cells["Marry"].Value;
              bool marry = (bool)value;

              FormDTO formDTO = new FormDTO
              {
                  Id = id,
                  Name = name,
                  Loadbirthday1 = birthDay,
                  Job = job,
                  Marry = marry
              };
              EditForm editor = new EditForm(formDTO);
      
                //editor.LoadData(id, name , birthDay, job, marry);
                editor.ShowDialog();
            }
            else
            {
                MessageBox.Show("NO Data Found","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void RegisterDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = RegisterInfoGrid.CurrentRow;
            if (row != null)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());

                DialogResult = MessageBox.Show("Are you sure to delete this item?", "Alert",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (DialogResult == DialogResult.OK)
                {
                    SqlDataDelete dataDelete = new SqlDataDelete();
                    dataDelete.delete(id);
                    MessageBox.Show("Data is Deleted","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Process canceled","Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No Data Found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SearchList_Click(object sender, EventArgs e)
        {
            SearchOption checkedOption = new SearchOption();
            string option = Category.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(Searchword.Text))
            {
                if (option == "ID")
                {
                    if (Int32.TryParse(Searchword.Text, out _))
                        RegisterInfoGrid.DataSource = checkedOption.DataOutput(checkedOption.FilterSearchQuery(SearchOption.SearchType.ID, Searchword.Text));
                    else
                    {
                        MessageBox.Show("You Selected Int Option, Input Intager ONLY", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (option == "Name")
                {
                    RegisterInfoGrid.DataSource = checkedOption.DataOutput(checkedOption.FilterSearchQuery(SearchOption.SearchType.Name, Searchword.Text));
                }
                else if (option == "Job")
                {
                    RegisterInfoGrid.DataSource = checkedOption.DataOutput(checkedOption.FilterSearchQuery(SearchOption.SearchType.Job, Searchword.Text));
                }
                else if (option == "AllData")
                {
                    RegisterInfoGrid.DataSource = checkedOption.DataOutput(checkedOption.FilterSearchQuery(SearchOption.SearchType.AllData, Searchword.Text));
                }
                else if (option == "Birthday")
                {
                    RegisterInfoGrid.DataSource = checkedOption.DataOutput(checkedOption.FilterSearchQuery(SearchOption.SearchType.Birthday, Searchword.Text));
                }
            }
            else
            {
                refresh();
            }
        }
        private void refresh()
        {
            DBconnect Connection = new DBconnect();
            DataSet ds = Connection.GetData();
            RegisterInfoGrid.DataSource = ds.Tables[0];
            RegisterInfoGrid.ReadOnly = true;
        }
        private void MemberManagement_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
