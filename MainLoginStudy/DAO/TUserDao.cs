using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLoginStudy.DAO
{
    class TUserDao
    {
        string connect_info = "DATA SOURCE = orcl; User Id = SYSTEM; Password = 1234";
        OracleConnection conn;
        OracleCommand cmd;

        /// <summary>
        /// 생성자 데이터베이스 참조용 
        /// </summary>
        public TUserDao()
        {

            // Oracle.DataAccess 참조중
            conn = new OracleConnection(connect_info);
            cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
        }

        /// <summary>
        /// T_USER SELECT SQL
        /// </summary>
        /// <param name="dbid"></param>
        /// <returns></returns>
        public string SelectTUser(string dbid, string dbpw)
        {
            string resultSql = string.Empty;
            string SQL = string.Empty;

            DataSet ds = new DataSet();
            SQL = "SELECT COUNT(1) FROM T_USER WHERE USER_ID = '" + dbid + "' AND USER_PW = '" + dbpw + "'";
            OracleDataAdapter ad = new OracleDataAdapter();
            ad.SelectCommand = new OracleCommand(SQL, conn);
            ad.Fill(ds, "test");
            conn.Close();
            //MessageBox.Show();

            resultSql =  (ds.Tables["test"].Rows[0][0]).ToString();

          

            return resultSql;
        }
    }
}
