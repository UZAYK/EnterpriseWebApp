using EnterpriseWebApp.Models.Model;
using System.Data.Entity;

namespace EnterpriseWebApp.Models.Context
{
    public class EnterpriseDB : DbContext
    {
        public EnterpriseDB() : base ("EnterpriseDB")
        {

        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Identity> Identities { get; set; }
    }
}