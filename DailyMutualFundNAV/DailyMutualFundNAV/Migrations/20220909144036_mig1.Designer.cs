﻿// <auto-generated />
using DailyMutualFundNAV.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DailyMutualFundNAV.Migrations
{
    [DbContext(typeof(MutualFundContext))]
    [Migration("20220909144036_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DailyMutualFundNAV.Models.DailyMutualFundDetail", b =>
                {
                    b.Property<int>("MutualFundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MutualFundName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MutualFundvalue")
                        .HasColumnType("float");

                    b.HasKey("MutualFundId");

                    b.ToTable("DailyMutualFundDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
