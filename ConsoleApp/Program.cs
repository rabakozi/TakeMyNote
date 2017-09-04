using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using TakeMyNote.Model;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp
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
                Console.Write("Enter a heading for a new Note: ");
                var name = Console.ReadLine();

                var note = new Note { Title = name };
                db.Notes.Add(note);
                db.SaveChanges();
                

                // Display all Blogs from the database
                var query = from n in db.Notes
                            select n;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Title);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
