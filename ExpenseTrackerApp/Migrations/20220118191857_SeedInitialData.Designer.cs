﻿// <auto-generated />
using ExpenseTrackerWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExpenseTrackerWebApp.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220118191857_SeedInitialData")]
    partial class SeedInitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ExpenseTrackerWebApp.Models.Expense", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("PersonId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            Amount = 10000m,
                            ItemName = "Car",
                            PersonId = 1
                        },
                        new
                        {
                            ItemId = 2,
                            Amount = 250m,
                            ItemName = "Watch",
                            PersonId = 1
                        },
                        new
                        {
                            ItemId = 3,
                            Amount = 20m,
                            ItemName = "Shoes",
                            PersonId = 1
                        });
                });

            modelBuilder.Entity("ExpenseTrackerWebApp.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PersonId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            FirstName = "Francesco",
                            LastName = "Tagliatti"
                        },
                        new
                        {
                            PersonId = 2,
                            FirstName = "Rachael",
                            LastName = "Kapple"
                        },
                        new
                        {
                            PersonId = 3,
                            FirstName = "Mark",
                            LastName = "Flynn"
                        });
                });

            modelBuilder.Entity("ExpenseTrackerWebApp.Models.Expense", b =>
                {
                    b.HasOne("ExpenseTrackerWebApp.Models.Person", "Person")
                        .WithMany("Expenses")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ExpenseTrackerWebApp.Models.Person", b =>
                {
                    b.Navigation("Expenses");
                });
#pragma warning restore 612, 618
        }
    }
}
