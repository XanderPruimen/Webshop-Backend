﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webshop_Backend.Context;

#nullable disable

namespace Webshop_Backend.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20221004075933_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Webshop_Backend.DTO_s.ItemDTO", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemID"), 1L, 1);

                    b.Property<string>("ItemInfo")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("ItemID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Webshop_Backend.DTO_s.OrderDTO", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"), 1L, 1);

                    b.Property<string>("Count")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<int>("UserAccountID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("UserAccountID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Webshop_Backend.DTO_s.UserDTO", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("AccountID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Webshop_Backend.DTO_s.OrderDTO", b =>
                {
                    b.HasOne("Webshop_Backend.DTO_s.UserDTO", "User")
                        .WithMany()
                        .HasForeignKey("UserAccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}