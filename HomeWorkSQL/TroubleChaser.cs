using System.Text;

namespace HomeWorkSQL
{
    class TroubleChaser
    {
        public bool lengthDetector(int id, string namebox, string job)
        {
            if ((id > 0 && id < 2147483647) && (namebox.Length < 30) && (job.Length < 30))
            { return true; }
            else
            { return false; }
        }
        public string emptydetector(bool idbox, bool Namebox, bool Jobbox)
        {
            StringBuilder emptyFields = new StringBuilder();
            if (idbox)
            {
                if (emptyFields.Length > 0)
                    emptyFields.Append(", ");
                emptyFields.Append("ID");
            }
            if (Namebox)
            {
                if (emptyFields.Length > 0)
                    emptyFields.Append(", ");
                emptyFields.Append("Name");
            }
            if (Jobbox)
            {
                if (emptyFields.Length > 0)
                    emptyFields.Append(", ");
                emptyFields.Append("Job");
            }
            emptyFields.Append(" is Empty");
            return emptyFields.Length > 0 ? emptyFields.ToString() : null;
        }
    }
}
