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

    }
}
