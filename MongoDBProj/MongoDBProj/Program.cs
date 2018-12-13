using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBProj
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoDBHelper mongodb = new MongoDBHelper();
            mongodb.InsertUser();
            mongodb.QueryUser();
            mongodb.UpdateUser();
            mongodb.QueryUser();
            mongodb.DeleteUser();
        }
    }
}
