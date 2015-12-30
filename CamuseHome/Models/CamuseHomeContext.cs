using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CamuseHome
{
    public class CamuseHomeContext : DbContext
    {
        public CamuseHomeContext()
        {
            this.Database.Log = str => System.Diagnostics.Debug.Write(str);
            // Turn off the Migrations, (NOT a code first Db)
            Database.SetInitializer<CamuseHomeContext>(null);
        }
        public DbSet<modCategory> Category { get; set; }
        public DbSet<modProduct> Product { get; set; }
        public DbSet<modPicture> Picture { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Database does not pluralize table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
