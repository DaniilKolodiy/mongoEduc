using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace ConsoleApp1
{
    class mClicntmDBMcol
    {
        static void Main(string[] args)
        {
            MainAsync(args).Wait();
            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }

        static async Task MainAsync(string[] args)
        {
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);

            var db = client.GetDatabase("test");
            //var collection = db.GetCollection<Person>("people");
        }
    }
}
