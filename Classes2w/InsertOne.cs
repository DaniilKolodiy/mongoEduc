using ConsoleApp1.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InsertOne
    {
        static void Main(string[] args)
        {
            MainAsync(args).Wait();
            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }
        static async Task MainAsync(string[]args)
        {
            var client = new MongoClient();
            var db = client.GetDatabase("test");
            var col = db.GetCollection<Person>("people");
            /* var doc = new BsonDocument
             {
                 { "Name", "Adam"},
                 {"Age", 30 },
                 {"Profession","Hacker" }
             };*/

            
            var doc = new Person
            {
                Name = "Jhosh",
                Age = 30,
                
                
            };

            /*var doc2 = new BsonDocument
            {
                {"SomthElse", true }
            };*/
            await col.InsertOneAsync(doc);
        }

    }
}
