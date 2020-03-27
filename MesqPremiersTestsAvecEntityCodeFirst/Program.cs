using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
namespace MesqPremiersTestsAvecEntityCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = builder.Build();
           
            string connectionstring = config.GetConnectionString("DefaultContext");
          
            //Comment il se connect
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(connectionstring);

            using (DefaultContext context = new DefaultContext(optionsBuilder.Options))
            {
                var query = from droide in context.Droides
                            select droide;
                foreach (var item in query.ToList())
                {
                    Console.WriteLine(item.Matricule);
                    Console.WriteLine("Hello world");

                }
            }
        }
    }
}
