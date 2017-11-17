using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;

namespace ConsoleApp1.Classes2w
{
    class PocoModels
    {
        static void Main(string[] args)
        {
            MainAsync(args).Wait();
            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }
        static async Task MainAsync(string[] args)
        {// representation of data
            /*BsonClassMap.RegisterClassMap<Person>(cm =>
            {
                cm.AutoMap();
                cm.MapMember(x => x.Name).SetElementName("name");
            }
            );*/
            var conventionPack = new ConventionPack();
            conventionPack.Add(new CamelCaseElementNameConvention());
            ConventionRegistry.Register("camelCase", conventionPack, t=> true);
            var person = new Person
            {
                Name = "Jones",
                Age = 30,
                Colors = new List<string>{"red", "blue"},
                Pets = new List<Pet>{new Pet {Name = "Fluf", Type = "Cat"}},
                ExtraElements = new BsonDocument("anatherName", "OneMore"),
            };
            using (var writer = new JsonWriter(Console.Out))
            {
                BsonSerializer.Serialize(writer,person);
            }
        }

    }
}
