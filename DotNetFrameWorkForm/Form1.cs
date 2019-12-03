using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace DotNetFrameWorkForm
{
    public partial class Form1 : Form
    {
        string connect_info = "DATA SOURCE = orcl; User Id = SYSTEM; Password = 1234";
        OracleConnection conn;
        OracleCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string SQL = "SELECT dname FROM REDO_DB WHERE rownum < 2";
            OracleDataAdapter ad = new OracleDataAdapter();
            ad.SelectCommand = new OracleCommand(SQL, conn);
            ad.Fill(ds, "test");

            MessageBox.Show(ds.Tables["test"].Rows[0][0].ToString());

            conn.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(connect_info);
            cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
        }
    }
}
