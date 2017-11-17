using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MainNameSpoace
{
    class Program
    {
        static void Main1(string[] args)
        {
            MainAsinc(args).GetAwaiter().GetResult();
            Console.WriteLine();
            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }

        static async Task MainAsinc(string[] args)
        {
            var client = new MongoClient();
        }
    }
}
