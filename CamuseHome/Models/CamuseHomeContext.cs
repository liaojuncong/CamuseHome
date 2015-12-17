using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome.Models
{
    public class CamuseHomeContext : DbContext
    {
        public CamuseHomeContext()
        {
            this.Database.Log = str => System.Diagnostics.Debug.Write(str);
            // Turn off the Migrations, (NOT a code first Db)
            Database.SetInitializer<CamuseHomeContext>(null);
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Picture> Picture { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Database does not pluralize table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
