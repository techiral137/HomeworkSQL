using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkSQL
{
  public partial class EditForm : Form
    {
        private readonly FormDTO _formDTO;
        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(FormDTO formDTO)
        {
          _formDTO = formDTO;
          InitializeComponent();
        }
        private void EditForm_Load(object sender, EventArgs e)
    {
      LoadData(_formDTO.Id, _formDTO.Name, _formDTO.Loadbirthday1, _formDTO.Job, _formDTO.Marry);
    }
        private void Edit_Click(object sender, EventArgs e)
        {
            DateTime birth = birthdayPicker.Value;
            string birthday = $"{birth.Year}/{birth.Month}/{birth.Day}";
            SqlDataUpdate update = new SqlDataUpdate();
            TroubleChaser lengthDetect = new TroubleChaser();
            if (!String.IsNullOrEmpty(idNumboxEdit.Text)&& !String.IsNullOrEmpty(nameBoxEdit.Text) && !String.IsNullOrEmpty(jobBoxEdit.Text))
            {
                if (lengthDetect.lengthDetector(Int32.Parse(idNumboxEdit.Text), nameBoxEdit.Text, jobBoxEdit.Text))
                {
                    update.sqlDataUpdate(Int32.Parse(idNumboxEdit.Text), nameBoxEdit.Text, birthday, jobBoxEdit.Text, MarryEdit.Checked);
                    MessageBox.Show("Data is Updated","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Text Length is over","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                TroubleChaser emptyDetector = new TroubleChaser();
                string emptyshow =
                    emptyDetector.emptydetector(String.IsNullOrEmpty(idNumboxEdit.Text),
                    String.IsNullOrEmpty(nameBoxEdit.Text), String.IsNullOrEmpty(jobBoxEdit.Text));
                MessageBox.Show(emptyshow + "\nFill in the Blank!!", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void LoadData(int id, string name, string Loadbirthday, string job, bool marry)
        {
            idNumboxEdit.Text = id.ToString();
            nameBoxEdit.Text = name.ToString();
            birthdayPicker.Value = Convert.ToDateTime(Loadbirthday);
            jobBoxEdit.Text = job.ToString();
            MarryEdit.Checked = marry;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   }
    public class FormDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Loadbirthday1 { get; set; }
        public string Job { get; set; }
        public bool Marry { get; set; }
    }
}
