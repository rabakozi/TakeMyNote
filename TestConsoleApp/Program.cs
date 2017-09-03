using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using TakeMyNote.Model;


// tipp
// https://www.hanselman.com/blog/ReferencingNETStandardAssembliesFromBothNETCoreAndNETFramework.aspx

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new ConfigurationBuilder()
            // .SetBasePath(Directory.GetCurrentDirectory())
            //.AddJsonFile("appsettings.json");

            //Configuration = builder.Build();
            EFTest();
        }

        private static void EFTest()
        {

            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();

            using (var db = new DatabaseContext(optionsBuilder.Options))
            {
                // Create and save a new Blog
               // Console.Write("Enter a heading for a new Note: ");
               // var name = Console.ReadLine();

                var note = new Note { Heading = "lofasz" + DateTime.Now.Second };
                db.Notes.Add(note);
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from n in db.Notes
                            select n;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Heading);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
