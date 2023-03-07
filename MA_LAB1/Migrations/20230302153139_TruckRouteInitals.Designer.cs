﻿// <auto-generated />
using MA_LAB1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MA_LAB1.Migrations
{
    [DbContext(typeof(TruckRouteDBContext))]
    [Migration("20230302153139_TruckRouteInitals")]
    partial class TruckRouteInitals
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MA_LAB1.Models.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountID"), 1L, 1);

                    b.Property<string>("CPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MA_LAB1.Models.Route", b =>
                {
                    b.Property<int>("RouteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RouteID"), 1L, 1);

                    b.Property<string>("r_length")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r_pay_per_km")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("route_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RouteID");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("MA_LAB1.Models.Truck", b =>
                {
                    b.Property<int>("TruckID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TruckID"), 1L, 1);

                    b.Property<int>("RouteID")
                        .HasColumnType("int");

                    b.Property<string>("t_make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("t_model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TruckID");

                    b.ToTable("Trucks");
                });
#pragma warning restore 612, 618
        }
    }
}
