using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Windows.Media.Media3D;

namespace ProductManagementApp.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<BOM> BOMs { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<BOM_Material> BOM_Materials { get; set; }
        public DbSet<ProductStageHistory> ProductStageHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=THEBEAST;Initial Catalog=ProductManagement;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurarea cheii primare pentru Material
            modelBuilder.Entity<Material>()
                .HasKey(m => m.Material_Number);

            // Configurarea cheii primare compuse pentru BOM_Material
            modelBuilder.Entity<BOM_Material>()
                .HasKey(bm => new { bm.Material_Number, bm.BOM_Id });

            // Configurarea cheii primare compuse pentru ProductStageHistory
            modelBuilder.Entity<ProductStageHistory>()
                .HasKey(psh => new { psh.Stage_Id, psh.Product_Id, psh.Start_Of_Stage });

            base.OnModelCreating(modelBuilder);
        }

    }
}
