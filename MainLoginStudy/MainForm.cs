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
    enum Drink
    {
        coffee1 = 1000,
        coffee2 = 2000,
        coffee3 = 3000,
        coffee4 = 4000,
        coffee5 = 5000,
        coffee6 = 6000
    }

    public partial class MainForm : Form
    {
        LoginForm loginForm;
        private int itemCnt = 0;
        private int sumMoney = 0;

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
                    //Application.Exit();

                    // 완전종료.
                    Environment.Exit(0);
              
                    break;
            }
        }

       

        // 로그인 석세스
        private void LoginSuccess(string userName)
        {
            MessageBox.Show(userName);
        }


        // button Click Event
        private void PlusButton1_Click(object sender, EventArgs e)
        {
            //버튼클릭시 가격 오름, 카운트1 증가
            cntTextBox.Text = "";
            moneyTextBox.Text = "";
            
     
            // 카운트증가 , 돈 증가
            ShowItemPlusCnt(Convert.ToInt32(Drink.coffee1));
        }

        private void MinusButton1_Click(object sender, EventArgs e)
        {
            //버튼클릭시 가격 오름, 카운트1 증가
            cntTextBox.Text = "";
            moneyTextBox.Text = "";

            // 카운트증가 , 돈 증가
            ShowItemMinusCnt(Convert.ToInt32(Drink.coffee1));
        }

        private void PlusButton2_Click(object sender, EventArgs e)
        {
            //버튼클릭시 가격 오름, 카운트1 증가
            cntTextBox.Text = "";
            moneyTextBox.Text = "";

            // 카운트증가 , 돈 증가
            ShowItemPlusCnt(Convert.ToInt32(Drink.coffee2));
        }

        private void MinusButton2_Click(object sender, EventArgs e)
        {
            //버튼클릭시 가격 오름, 카운트1 증가
            cntTextBox.Text = "";
            moneyTextBox.Text = "";

            // 카운트증가 , 돈 증가
            ShowItemMinusCnt(Convert.ToInt32(Drink.coffee2));
        }

        private void PlusButton3_Click(object sender, EventArgs e)
        {
            //버튼클릭시 가격 오름, 카운트1 증가
            cntTextBox.Text = "";
            moneyTextBox.Text = "";

            // 카운트증가 , 돈 증가
            ShowItemPlusCnt(Convert.ToInt32(Drink.coffee3));
        }

        private void MinusButton3_Click(object sender, EventArgs e)
        {
            //버튼클릭시 가격 오름, 카운트1 증가
            cntTextBox.Text = "";
            moneyTextBox.Text = "";

            // 카운트증가 , 돈 증가
            ShowItemMinusCnt(Convert.ToInt32(Drink.coffee3));
        }

        private void PlusButton4_Click(object sender, EventArgs e)
        {
            //버튼클릭시 가격 오름, 카운트1 증가
            cntTextBox.Text = "";
            moneyTextBox.Text = "";

            // 카운트증가 , 돈 증가
            ShowItemPlusCnt(Convert.ToInt32(Drink.coffee4));
        }

        private void MinusButton4_Click(object sender, EventArgs e)
        {
            //버튼클릭시 가격 오름, 카운트1 증가
            cntTextBox.Text = "";
            moneyTextBox.Text = "";

            // 카운트증가 , 돈 증가
            ShowItemMinusCnt(Convert.ToInt32(Drink.coffee4));
        }

        private void PlusButton5_Click(object sender, EventArgs e)
        {
            //버튼클릭시 가격 오름, 카운트1 증가
            cntTextBox.Text = "";
            moneyTextBox.Text = "";

            // 카운트증가 , 돈 증가
            ShowItemPlusCnt(Convert.ToInt32(Drink.coffee5));
        }

        private void MinusButton5_Click(object sender, EventArgs e)
        {
            //버튼클릭시 가격 오름, 카운트1 증가
            cntTextBox.Text = "";
            moneyTextBox.Text = "";

            // 카운트증가 , 돈 증가
            ShowItemMinusCnt(Convert.ToInt32(Drink.coffee5));
        }

        private void PlusButton6_Click(object sender, EventArgs e)
        {
            //버튼클릭시 가격 오름, 카운트1 증가
            cntTextBox.Text = "";
            moneyTextBox.Text = "";

            // 카운트증가 , 돈 증가
            ShowItemPlusCnt(Convert.ToInt32(Drink.coffee6));
        }

        private void MinusButton6_Click(object sender, EventArgs e)
        {
            //버튼클릭시 가격 오름, 카운트1 증가
            cntTextBox.Text = "";
            moneyTextBox.Text = "";

            // 카운트증가 , 돈 증가
            ShowItemMinusCnt(Convert.ToInt32(Drink.coffee6));
        }

        public void ShowItemPlusCnt(int item)
        {
            //plus cnt
            itemCnt += 1;
            //enum money
            sumMoney += item;

            // 텍스트에출력
            cntTextBox.Text = Convert.ToString(itemCnt);
            moneyTextBox.Text = Convert.ToString(sumMoney);
        }

        public void ShowItemMinusCnt(int item)
        {
    
            if (itemCnt > 0 && sumMoney >0)
            {
                //plus cnt
                itemCnt -= 1;
                //enum money
                sumMoney -= item;
            }
           
            // 텍스트에출력
            cntTextBox.Text = Convert.ToString(itemCnt);
            moneyTextBox.Text = Convert.ToString(sumMoney);
        }

        private void AllClearItem_Click(object sender, EventArgs e)
        {
            itemCnt = 0;
            sumMoney = 0;
            cntTextBox.Text = "";
            moneyTextBox.Text = "";
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            // 결재확인화면 이동



        }

        // 전체 트리뷰
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //e.Node.Parent
        }
    }
}
