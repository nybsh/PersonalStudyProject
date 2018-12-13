using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nycy.DbTools
{
    internal class MySqlConnection
    {
        private static volatile MySqlConnection instance = null;
        private static SqlConnection sqlConnection = null;
        private static int lockInter = 1;
        private MySqlConnection() { }
        public static MySqlConnection Instance
        {
            get
            {
                if(instance == null)
                {
                    if(Interlocked.CompareExchange(ref lockInter, 1, 0) == 0)
                    {
                        if(instance == null)
                        {
                            instance = new MySqlConnection();
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
                sqlConnection = new SqlConnection(connStr);
                sqlConnection.Open();
            }
        }
        public SqlConnection GetSqlServerConn()
        {
            return sqlConnection;
        }
        public void DisposeConn()
        {
            if(sqlConnection != null)
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }
    }
}
