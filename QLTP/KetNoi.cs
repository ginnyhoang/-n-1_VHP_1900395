using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLTP
{
    class KetNoi
    {
        public static SqlConnection GetConnection(string datasource, string db, string user, string pass)
        {
            string StrConn = "Data Source = " + datasource +
                "; Initial Catalog  = " + db +
                "; User ID = " + user +
                "; Password  = " + pass;
            SqlConnection conn = new SqlConnection(StrConn);
            return conn;
        }
        public static SqlConnection GetConnection(string datasource, string db)
        {

            string StrConn = "Data Source = " + datasource +
                "; Initial Catalog  = " + db +
                "Intergrated security = SSPI";
            SqlConnection conn = new SqlConnection(StrConn);
            return conn;
        }
        public static SqlConnection GetConnection()
        {
            string datasource = @"laptop-upe38rvj\sqlexpress";
            string db = "QLTP";
            string user = "sa";
            string pass = "123456";
            return GetConnection(datasource, db, user, pass);
        }
    }
}
