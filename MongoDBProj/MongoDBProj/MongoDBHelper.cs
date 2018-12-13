using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBProj
{
    public class MongoDBHelper
    {
        public const string conn = "mongodb://localhost";
        public const string database = "gcTest";
        public const string collection = "Users";

        private MongoServer mongodb = null;
        private MongoDatabase mongoDataBase = null;
        private MongoCollection mongoCollection = null;
        public MongoDBHelper()
        {
            InitDb();
        }
        private void InitDb()
        {
            mongodb = (new MongoClient(conn)).GetServer();
            mongoDataBase = mongodb.GetDatabase(database);
            mongoCollection = mongoDataBase.GetCollection(collection);
        }
        public void InsertUser()
        {
            Users user = new Users()
            {
                Name = "gc",
                Sex = "man"
            };
            mongoCollection.Insert<Users>(user);
        }
        public void UpdateUser()
        {
            var query = new QueryDocument { { "Name", "gc" } };
            var update = new UpdateDocument { { "$set", new QueryDocument { { "Sex", "wowen" } } } };
            mongoCollection.Update(query, update);
        }
        public void QueryUser()
        {
            var query = new QueryDocument { { "Name", "gc" } };
            //查询全部集合里的数据 
            var result1 = mongoCollection.FindAllAs<Users>();
            //查询指定查询条件的第一条数据，查询条件可缺省。 
            var result2 = mongoCollection.FindOneAs<Users>();
            //查询指定查询条件的全部数据 
            var result3 = mongoCollection.FindAs<Users>(query);
        }
        public void DeleteUser()
        {
            var query = new QueryDocument { { "Name", "gc" } };
            mongoCollection.Remove(query);
        }
    }
}
