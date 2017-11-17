using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace ConsoleApp1.Classes2w
{
    class DocRepres
    {
        static void Main(string[] args)
        {
            MainAsync(args).Wait();
            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }
        static async Task MainAsync(string[] args)
        {
            var doc = new BsonDocument
            {
                {"name","Jones"}
            };
            doc.Add("age", 30);
            doc["profession"] = "hacker";
            var nestedArray = new BsonArray();
            nestedArray.Add(new BsonDocument("color","red"));
            doc.Add("array",nestedArray);
            Console.WriteLine(doc["array"][0]["color"]);
            Console.WriteLine(doc);
        }
    }
}
