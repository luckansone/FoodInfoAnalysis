using FoodHazardAnalysis.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHazardAnalysis.Interfaces.DbContext
{
    public interface IContext
    {
         DbSet<Eadditives> Eadditives { get; set; }
         DbSet<MigrationHistory> MigrationHistory { get; set; }
         DbSet<ProductAdditives> ProductAdditives { get; set; }
         DbSet<Products> Products { get; set; }

    }
}
