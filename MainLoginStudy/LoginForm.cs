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
    public delegate void EventHandler(string userName);
    public partial class LoginForm : Form
    {
        //MainForm mainForm = new MainForm();
        public event EventHandler LoginEventHandler;

        public LoginForm()
        {
            InitializeComponent();
        }

        public void OK_Click(object sender, EventArgs e)
        {
            LoginHandler loginHandler = new LoginHandler();

            // 아이디,비번 널 체크
            if (ControlCheck())
            {
                // 널값아닐때 로그인 가능
                if (loginHandler.LoginCheck(UsernameTextBox.Text, PasswordTextBox.Text)) // 아이디 비번 확인중
                {
                    string userName = UsernameTextBox.Text; //로그인폼 생성
                    LoginEventHandler(userName);
                    DialogResult = DialogResult.OK;
                }
                // 널값아닐때 로그인 불가
                else
                {
                    MessageBox.Show("아이디 혹은 비밀번호를 다시 확인해주시기 바랍니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
                    UsernameTextBox.Clear();
                    PasswordTextBox.Clear();
                }
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

            //캔슬입력시 클로즈
            this.Close();
        }

        //널체크기
        private bool ControlCheck()
        {
            //아이디체크
            if (String.IsNullOrEmpty(UsernameTextBox.Text))
            {
                //실패
                return false;
            }
            //비번체크
            else if (String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                //실패
                return false;
            }
            //성공
            return true;
        }

        //버튼key검증
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys key = keyData & ~(Keys.Shift | Keys.Control);
            switch (key)
            {
                // enterKey
                case Keys.Enter:
                    //if ((keyData & Keys.Control) != 0)
                    //{
                        //LoginForm loginForm = new LoginForm();
                        //loginForm.OK_Click
            
                        OK.PerformClick(); // OK엔터시클릭.
                        return true;
                    //}
                    /*break;*/
            }
            return false;

        }




    }
}
