﻿// <auto-generated />
using BP_CalHFA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BP_CalHFA.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("BP_CalHFA.Data.CalHFA", b =>
                {
                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("LoanCategoryID")
                        .HasColumnType("int");

                    b.Property<int>("LoanID")
                        .HasColumnType("int");

                    b.Property<int>("StatusCode")
                        .HasColumnType("int");

                    b.Property<string>("StatusDate")
                        .HasColumnType("text");

                    b.ToTable("CalHFADB");
                });
#pragma warning restore 612, 618
        }
    }
}
