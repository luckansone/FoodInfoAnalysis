using System;
using FoodHazardAnalysis.Interfaces.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FoodHazardAnalysis.Models
{
    public partial class FoodHazardBotDBContext : DbContext, IContext
    {
        public FoodHazardBotDBContext()
        {
        }

        public FoodHazardBotDBContext(DbContextOptions<FoodHazardBotDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Eadditives> Additives { get; set; }
        public virtual DbSet<ProductAdditives> ProductAdditives { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Eadditives>(entity =>
        //    {
        //        entity.ToTable("Additives");
        //    });

        //    modelBuilder.Entity<MigrationHistory>(entity =>
        //    {
        //        entity.HasKey(e => new { e.MigrationId, e.ContextKey });

        //        entity.ToTable("__MigrationHistory");

        //        entity.Property(e => e.MigrationId).HasMaxLength(150);

        //        entity.Property(e => e.ContextKey).HasMaxLength(300);

        //        entity.Property(e => e.Model).IsRequired();

        //        entity.Property(e => e.ProductVersion)
        //            .IsRequired()
        //            .HasMaxLength(32);
        //    });

        //    modelBuilder.Entity<ProductAdditives>(entity =>
        //    {
        //        entity.HasIndex(e => e.EadditiveId)
        //            .HasName("IX_Additive_Id");

        //        entity.HasIndex(e => e.ProductId)
        //            .HasName("IX_Product_Id");

        //        entity.Property(e => e.EadditiveId).HasColumnName("Additive_Id");

        //        entity.Property(e => e.ProductId).HasColumnName("Product_Id");

        //        entity.HasOne(d => d.Eadditive)
        //            .WithMany(p => p.ProductAdditives)
        //            .HasForeignKey(d => d.EadditiveId)
        //            .HasConstraintName("FK_dbo.ProductAdditives_dbo.Additives_EAdditive_Id");

        //        entity.HasOne(d => d.Product)
        //            .WithMany(p => p.ProductAdditives)
        //            .HasForeignKey(d => d.ProductId)
        //            .HasConstraintName("FK_dbo.ProductAdditives_dbo.Products_Product_Id");
        //    });
        //}
    }
}
