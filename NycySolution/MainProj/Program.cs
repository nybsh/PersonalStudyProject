using Nycy.DbTools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new GcTest();
            string test = t.GetValue();
            t.ChangeValue("aaa");
            test = t.GetValue();
            var s = new GcTest();
            test = s.GetValue();
            s.ChangeValue("ttt");
            test = t.GetValue();
            test = s.GetValue();
            //TestMySqlOpt();
            string path = Path.Combine(@"C:\Program Files\Autodesk\AutoCAD 2014", "ZNBPlugin.dll");
            if (File.Exists(path))
            {
                string Version = System.Diagnostics.FileVersionInfo.GetVersionInfo(path).FileVersion;
                string Name = new System.IO.FileInfo(path).Name;
                long FileSize = new System.IO.FileInfo(path).Length;
            }
        }
        public static void TestMySqlOpt()
        {
            string connectionStr = ConfigurationManager.AppSettings["SqlServer.ConnectionStr"];
            SqlServerHelper sqlHelper = new SqlServerHelper();
            sqlHelper.Init(connectionStr);
            //            sqlHelper.ExecuteNonQuery(@"INSERT INTO Users(Name, ShortName, Address, Tel, Status)
            //VALUES('gongchao', 'gc', '武汉', '123456', 1)");
            DataTable userTbl = sqlHelper.FillDataTable("select * from Users");
        }
    }
    class GcTest
    {
        private static string temp = "ssss";
        public void ChangeValue(string str)
        {
            temp += str;
        }
        public string GetValue()
        {
            return temp;
        }
    }
}
