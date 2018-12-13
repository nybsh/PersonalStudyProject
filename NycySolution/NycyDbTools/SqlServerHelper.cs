using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nycy.DbTools
{
    public class SqlServerHelper
    {
        /// <summary>
        /// 初始化数据库连接
        /// </summary>
        public Tuple<bool, string> Init(string connectionStr)
        {
            bool isSuccess = true;
            string retMsg = string.Empty;
            if (!string.IsNullOrWhiteSpace(connectionStr))
            {
                try
                {
                    MySqlConnection.Instance.Init(connectionStr);
                }
                catch (Exception ex)
                {
                    isSuccess = false;
                    retMsg = ex.Message;
                }
            }
            else
            {
                isSuccess = false;
                retMsg = "数据库链接字符串为空";
            }
            return Tuple.Create(isSuccess, retMsg);
        }

        public bool ExecuteNonQuery(string sql)
        {
            SqlConnection sqlconn = MySqlConnection.Instance.GetSqlServerConn();
            if(sqlconn == null)
            {
                return false;
            }
            using (SqlCommand cmd = new SqlCommand(sql, sqlconn))
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public DataTable FillDataTable(string sql)
        {
            DataTable resultDt = new DataTable();
            SqlConnection sqlconn = MySqlConnection.Instance.GetSqlServerConn();
            if (sqlconn == null)
            {
                return null;
            }
            SqlDataAdapter sqlAdp = new SqlDataAdapter(sql, sqlconn);
            sqlAdp.Fill(resultDt);
            return resultDt;
        }
        public DataSet FillDataSet(string sql)
        {
            DataSet resultDs = new DataSet();
            SqlConnection sqlconn = MySqlConnection.Instance.GetSqlServerConn();
            if (sqlconn == null)
            {
                return null;
            }
            SqlDataAdapter sqlAdp = new SqlDataAdapter(sql, sqlconn);
            sqlAdp.Fill(resultDs);
            return resultDs;
        }
        public int UpdateDataTable(string sql)
        {
            DataTable resultDt = new DataTable();
            SqlConnection sqlconn = MySqlConnection.Instance.GetSqlServerConn();
            if (sqlconn == null)
            {
                return 0;
            }
            SqlDataAdapter sqlAdp = new SqlDataAdapter(sql, sqlconn);
            sqlAdp.Fill(resultDt);

            SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(sqlAdp);//这句很重要，自动生成sql命令
            DataRow drInsert = resultDt.NewRow();//新建一行
            drInsert[1] = "test";
            resultDt.Rows.Add(drInsert);//将新行插入数据表

            return sqlAdp.Update(resultDt);//更新数据表
        }
    }
}
