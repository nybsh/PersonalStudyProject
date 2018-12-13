using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBProj
{
    public class Users
    {
        public Object _id;//BsonType.ObjectId 这个对应了 MongoDB.Bson.ObjectId  　　　　
        public string Name { get; set; }
        public string Sex { set; get; }
    }
}
