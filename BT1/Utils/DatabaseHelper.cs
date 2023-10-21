using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1.Utils
{
    internal class DatabaseHelper
    {
        public static String ServerName;
        public static String dbName;
        public static String userDb;
        public static String password;

        public static SqlConnection GetConnection()
        {
            String strCon = "server = " + ServerName +
                "; Initial Catalog = " + dbName +
                "; uid = " + userDb +
                "; pwd = " + password;
            return new SqlConnection(strCon);
        }
        
    }
}
