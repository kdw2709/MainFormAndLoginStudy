using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainLoginStudy
{
    public partial class MainForm : Form
    {
        LoginForm loginForm;

        public MainForm()
        {
            InitializeComponent();
    
            loginForm = new LoginForm();
            loginForm.LoginEventHandler += new EventHandler(LoginSuccess);

            // dialog표시
            switch (loginForm.ShowDialog())
            {
                case DialogResult.OK:
                    loginForm.Close();
                    break;
                case DialogResult.Cancel:
                    Dispose();
                    break;
            }

        }


        // 로그인 석세스
        private void LoginSuccess(string userName)
        {
            MessageBox.Show(userName);
        }
    }
}
