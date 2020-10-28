using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Code_first_approach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new database of bloggingContext
            using (var db = new BloggingContext())
            {
                //Creating a writeline asking for a name and a variable that takes the name written
                Console.WriteLine("Enter a name for a new blog: ");
                var name = Console.ReadLine();

                //Making a new blogpost with the blog name
                var blog = new Blog { Name = name };
                //Adding the post to the blog
                db.Blogs.Add(blog);
                //Saving the changes
                db.SaveChanges();

                //Making a query variable that selects all of the lbogs
                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                //Writeline explaining the showing of all of the blog entities in the database
                Console.WriteLine("All blogs in the database: ");
                //Foreach statement for showing all of the blog entities in the database
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                //Exit message and waiting on a keyinput to exit from
                Console.WriteLine("Press any key to exit-");
                Console.ReadKey();
            }
        }
    }

    //Making a blog table
    public class Blog
    {
        //Here the columns for the blog table is created
        public int BlogId { get; set; }
        public string Name { get; set; }

        //Making a primary key for the table
        public virtual List<Post> Posts { get; set; }
    }

    //Making a post table
    public class Post
    {
        //Here the columns for the post table is created
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        
        public int BlogId { get; set; }
        //Making a primary key. and a foreignkey that references the BlogId
        public virtual Blog Blog { get; set; }
    }

    //Using inheritance of the DbContext class
    public class BloggingContext : DbContext
    {
        //Making 2 data sets for the 2 tables
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
