﻿// <auto-generated />
using System;
using ExpenseTrackerWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExpenseTrackerWebApp.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

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
                            Date = new DateTime(2022, 1, 20, 21, 51, 39, 301, DateTimeKind.Local).AddTicks(2931),
                            ItemName = "Car",
                            PersonId = 1
                        },
                        new
                        {
                            ItemId = 2,
                            Amount = 250m,
                            Date = new DateTime(2022, 1, 20, 21, 51, 39, 302, DateTimeKind.Local).AddTicks(7769),
                            ItemName = "Watch",
                            PersonId = 1
                        },
                        new
                        {
                            ItemId = 3,
                            Amount = 40m,
                            Date = new DateTime(2022, 1, 20, 21, 51, 39, 302, DateTimeKind.Local).AddTicks(7804),
                            ItemName = "Shoes",
                            PersonId = 1
                        },
                        new
                        {
                            ItemId = 4,
                            Amount = 20m,
                            Date = new DateTime(2022, 1, 20, 21, 51, 39, 302, DateTimeKind.Local).AddTicks(7808),
                            ItemName = "Umbrella",
                            PersonId = 2
                        },
                        new
                        {
                            ItemId = 5,
                            Amount = 10m,
                            Date = new DateTime(2022, 1, 20, 21, 51, 39, 302, DateTimeKind.Local).AddTicks(7810),
                            ItemName = "Book",
                            PersonId = 2
                        },
                        new
                        {
                            ItemId = 6,
                            Amount = 1000m,
                            Date = new DateTime(2022, 1, 20, 21, 51, 39, 302, DateTimeKind.Local).AddTicks(8069),
                            ItemName = "Computer",
                            PersonId = 3
                        },
                        new
                        {
                            ItemId = 7,
                            Amount = 10m,
                            Date = new DateTime(2022, 1, 20, 21, 51, 39, 302, DateTimeKind.Local).AddTicks(8071),
                            ItemName = "Hat",
                            PersonId = 3
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