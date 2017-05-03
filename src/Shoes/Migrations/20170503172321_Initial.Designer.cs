using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Shoes.Models;

namespace Shoes.Migrations
{
    [DbContext(typeof(ShoesDbContext))]
    [Migration("20170503172321_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shoes.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Revenue");

                    b.Property<int>("Stock");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Shoes.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<string>("Image");

                    b.Property<int?>("InventoryId");

                    b.Property<int>("Price");

                    b.Property<string>("ShoeName");

                    b.HasKey("SaleId");

                    b.HasIndex("InventoryId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Shoes.Models.Sale", b =>
                {
                    b.HasOne("Shoes.Models.Inventory", "Inventory")
                        .WithMany("Sales")
                        .HasForeignKey("InventoryId");
                });
        }
    }
}
