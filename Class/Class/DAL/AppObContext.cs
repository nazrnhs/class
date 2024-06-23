using Class.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Class.DAL
{
    internal class AppObContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Server = LAPTOP-EV9VETMQ\\SQLEXPRESS; Database = C#Ders; Encrypt= False; Trusted_Connection = True");
            base.OnConfiguring(optionsBuilder);
        }

         public DbSet<Book> Books{ get; set; }
         public DbSet<Person> Persons { get; set; }
         public DbSet<Teacher> Teachers { get; set; }
    }
}
