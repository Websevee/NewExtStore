using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ExtStore.Models.User;
using ExtStore.Models;

namespace ExtStore.DAL
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext() : base("Database") { }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }


        /*
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }
        */

    }
}