using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DBTool
{
    internal class SqlConnectionHelper
    {
        private static volatile SqlConnectionHelper instance = null;
        private static MySqlConnection sqlConnection = null;
        private static int lockInter = 0;
        private SqlConnectionHelper() { }
        public static SqlConnectionHelper Instance
        {
            get
            {
                if(instance == null)
                {
                    if(Interlocked.CompareExchange(ref lockInter, 1, 0) == 0)
                    {
                        if(instance == null)
                        {
                            instance = new SqlConnectionHelper();
                        }
                        Interlocked.CompareExchange(ref lockInter, 0, 1);
                    }
                }
                return instance;
            }
        }
        public void Init(string connStr)
        {
            if(sqlConnection == null)
            {
                sqlConnection = new MySqlConnection(connStr);
                sqlConnection.Open();
            }
        }
        public MySqlConnection GetSqlServerConn()
        {
            return sqlConnection;
        }
        public void DisposeConn()
        {
            if(sqlConnection != null)
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
                sqlConnection = null;
            }
        }
    }
}
