﻿// <auto-generated />
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessLayer.Clothing", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.ToTable("Clothes");

                    b.HasData(
                        new
                        {
                            Name = "Red linen jacket",
                            Brand = "LC Waikiki",
                            Color = "Red",
                            Price = 50.0,
                            Size = "46",
                            Type = 0
                        },
                        new
                        {
                            Name = "Jean Shirt",
                            Brand = "Wyoming",
                            Color = "Light Blue",
                            Price = 15.0,
                            Size = "L",
                            Type = 1
                        },
                        new
                        {
                            Name = "Black Linen Trousers",
                            Brand = "LC Waikiki",
                            Color = "Black",
                            Price = 40.0,
                            Size = "34",
                            Type = 2
                        },
                        new
                        {
                            Name = "Sports Shoes",
                            Brand = "Decathlon",
                            Color = "Light Brown",
                            Price = 35.0,
                            Size = "44",
                            Type = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
