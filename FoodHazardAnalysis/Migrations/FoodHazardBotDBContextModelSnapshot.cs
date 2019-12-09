﻿// <auto-generated />
using System;
using FoodHazardAnalysis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FoodHazardAnalysis.Migrations
{
    [DbContext(typeof(FoodHazardBotDBContext))]
    partial class FoodHazardBotDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("FoodHazardAnalysis.Models.Eadditives", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("Danger");

                    b.Property<string>("FullName");

                    b.Property<string>("Name");

                    b.Property<string>("Origin");

                    b.HasKey("Id");

                    b.ToTable("Additives");
                });

            modelBuilder.Entity("FoodHazardAnalysis.Models.ProductAdditives", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EadditiveId");

                    b.Property<int?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("EadditiveId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductAdditives");
                });

            modelBuilder.Entity("FoodHazardAnalysis.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Calories");

                    b.Property<string>("Carbohydrates");

                    b.Property<string>("Composition");

                    b.Property<string>("Fats");

                    b.Property<string>("Name");

                    b.Property<string>("Protein");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FoodHazardAnalysis.Models.ProductAdditives", b =>
                {
                    b.HasOne("FoodHazardAnalysis.Models.Eadditives", "Eadditive")
                        .WithMany("ProductAdditives")
                        .HasForeignKey("EadditiveId");

                    b.HasOne("FoodHazardAnalysis.Models.Products", "Product")
                        .WithMany("ProductAdditives")
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
