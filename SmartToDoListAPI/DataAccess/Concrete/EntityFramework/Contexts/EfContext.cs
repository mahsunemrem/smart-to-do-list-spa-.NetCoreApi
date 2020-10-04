using Microsoft.EntityFrameworkCore;
using SmartToDoListAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.DataAccess.Concrete.EntityFramework.Contexts
{
    public class EfContext : DbContext
    {

        //public EfContext(DbContextOptions<EfContext> options)
        //   : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"server=127.0.0.1;database=testdb2;Uid=test;Pwd=1;");
            //@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NorthwindBackend;Integrated Security=True;"
            //@"server=localhost;port=3306;database=yigisoftcafeapp;user id=root;password=mysql1234;"
            //@"server=94.73.170.169;database=u9290090_cafeapi;Uid=u9290090_userCD9;Pwd=PTdc90O7RNda85D;"
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<ToDoItem> ToDoItem { get; set; }
        public DbSet<ToDoTitle> ToDoTitle { get; set; }
        public DbSet<User> User { get; set; }

    }
}