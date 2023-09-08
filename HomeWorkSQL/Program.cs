using System;
using System.Windows.Forms;

namespace HomeWorkSQL
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm Login = new LoginForm();
            if(Login.ShowDialog() == DialogResult.OK)
            {
                MemberManagement memberManagement = new MemberManagement();
                Application.Run(memberManagement);
            }
        }
    }
}
