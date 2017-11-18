using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ConsoleApp1.Models
{
    public class  Person
    {
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonRepresentation((BsonType.String))]
        public int Age { get; set; }
        public List<string> Colors { get; set; }
        public  List<Pet> Pets { get; set; }
        public BsonDocument ExtraElements { get; set; }
    }
}
