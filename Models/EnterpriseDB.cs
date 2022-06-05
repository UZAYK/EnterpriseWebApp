using System.Data.Entity;

namespace EnterpriseWebApp.Models
{
    public partial class EnterpriseDB : DbContext
    {
        public EnterpriseDB()
            : base("name=EnterpriseDB")
        {
        }

        public virtual DbSet<AboutU> AboutUs { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Identity> Identities { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
