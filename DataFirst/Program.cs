using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DataFirstModelEntities();
            var post = new Post()
            {
                Id = 1,
                Fname = "sulu",
                Age = 21
            };

            context.Posts.Add(post);
            context.SaveChanges();
            Console.WriteLine("done");
            Console.Read();
        }
    }
}
