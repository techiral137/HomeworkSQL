using System;
using System.Windows.Forms;

namespace HomeWorkSQL
{
    public partial class MemberRegister : Form
    {
        public bool flag;
        public MemberRegister()
        {
            InitializeComponent();
        }
        private void registBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idNumbox.Text) && !String.IsNullOrEmpty(NameBox.Text) && !String.IsNullOrEmpty(jobBox.Text))
            {
                DateTime birth = birthdayPicker.Value;
                string birthday = $"{birth.Year}/{birth.Month}/{birth.Day}";
                IDisExist exist = new IDisExist();
                bool canConvert = Int32.TryParse(idNumbox.Text, out int id);
                TroubleChaser lengthDetector = new TroubleChaser();
                if (canConvert == true)
                {
                    if (lengthDetector.lengthDetector(Int32.Parse(idNumbox.Text),NameBox.Text,jobBox.Text))
                    {
                        if (exist.IdIsExist(id) == false)
                        {
                            SqlDataAdder sqlAdder = new SqlDataAdder();

                            sqlAdder.sqlAdder(id, NameBox.Text, birthday, jobBox.Text, Marry.Checked);
                            flag = true;
                            if (flag == true)
                            {
                                MessageBox.Show("added complete!");
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("ID is already Used");
                        }
                    }
                    else
                    {
                        MessageBox.Show("TextLength is Over");
                    }
                }
                else
                {
                    MessageBox.Show("ID is not integer");
                }
            }
            else
            {
                TroubleChaser emptyDetector = new TroubleChaser();
                string emptyshow = 
                    emptyDetector.emptydetector(String.IsNullOrEmpty(idNumbox.Text),
                    String.IsNullOrEmpty(NameBox.Text),String.IsNullOrEmpty(jobBox.Text));
                MessageBox.Show(emptyshow + "\nFill in the Blank!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

