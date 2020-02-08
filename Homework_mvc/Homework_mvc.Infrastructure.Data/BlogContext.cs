using Homework_mvc.Entity.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_mvc.Infrastructure.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("DefaultConnection")
        {
            // Database.CreateIfNotExists();
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Profile> Profiles { get; set; }

    }
}
