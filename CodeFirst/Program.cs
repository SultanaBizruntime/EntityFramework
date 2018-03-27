using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
   public class Posts
   {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
   }
    public class CodeDbContext : DbContext
    {
        public DbSet<Posts> Posts { get; set; }
    }
    class Program
    {
       static void Main(string[] args)
        {
            var context = new CodeDbContext();
            var post = new Posts()
            {
                PostID=1,
                Title="Title",
                Body="Body"
            };
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}





//after that we connect to the sql server then in the powershell we can type
//enable-migrations after that
//we can create (or) modify anything for that we can type
//add-migration CreatePost(Tablename)
