﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebInvManagement.Data;

#nullable disable

namespace WebInvManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240428140907_AddProductionStockFields")]
    partial class AddProductionStockFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebInvManagement.Models.ABCGroup", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StrategyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StrategyId");

                    b.ToTable("ABCGroups");
                });

            modelBuilder.Entity("WebInvManagement.Models.IMStrategy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IMStrategys");
                });

            modelBuilder.Entity("WebInvManagement.Models.Order", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("StockTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StockTypeId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebInvManagement.Models.ProductionStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ABCId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastOrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LeadTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxOrderQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("MinOrderQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ServiceLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StockTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("XYZId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ABCId");

                    b.HasIndex("StockTypeId");

                    b.HasIndex("XYZId");

                    b.ToTable("ProductionStocks");
                });

            modelBuilder.Entity("WebInvManagement.Models.Report", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("StockTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("StockTypeId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("WebInvManagement.Models.StockType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StockTypes");
                });

            modelBuilder.Entity("WebInvManagement.Models.Supplier", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StockTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StockTypeId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("WebInvManagement.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebInvManagement.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebInvManagement.Models.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("WebInvManagement.Models.WarehouseProductionStock", b =>
                {
                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.Property<int>("ProductionStockId")
                        .HasColumnType("int");

                    b.HasKey("WarehouseId", "ProductionStockId");

                    b.HasIndex("ProductionStockId");

                    b.ToTable("WarehouseProductionStocks");
                });

            modelBuilder.Entity("WebInvManagement.Models.XYZGroup", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StrategyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StrategyId");

                    b.ToTable("XYZGroups");
                });

            modelBuilder.Entity("WebInvManagement.Models.ABCGroup", b =>
                {
                    b.HasOne("WebInvManagement.Models.IMStrategy", "Strategy")
                        .WithMany()
                        .HasForeignKey("StrategyId");

                    b.Navigation("Strategy");
                });

            modelBuilder.Entity("WebInvManagement.Models.Order", b =>
                {
                    b.HasOne("WebInvManagement.Models.StockType", "StockType")
                        .WithMany()
                        .HasForeignKey("StockTypeId");

                    b.Navigation("StockType");
                });

            modelBuilder.Entity("WebInvManagement.Models.ProductionStock", b =>
                {
                    b.HasOne("WebInvManagement.Models.ABCGroup", "ABCGroup")
                        .WithMany()
                        .HasForeignKey("ABCId");

                    b.HasOne("WebInvManagement.Models.StockType", "StockType")
                        .WithMany()
                        .HasForeignKey("StockTypeId");

                    b.HasOne("WebInvManagement.Models.XYZGroup", "XYZGroup")
                        .WithMany()
                        .HasForeignKey("XYZId");

                    b.Navigation("ABCGroup");

                    b.Navigation("StockType");

                    b.Navigation("XYZGroup");
                });

            modelBuilder.Entity("WebInvManagement.Models.Report", b =>
                {
                    b.HasOne("WebInvManagement.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("WebInvManagement.Models.StockType", "StockType")
                        .WithMany()
                        .HasForeignKey("StockTypeId");

                    b.Navigation("Order");

                    b.Navigation("StockType");
                });

            modelBuilder.Entity("WebInvManagement.Models.Supplier", b =>
                {
                    b.HasOne("WebInvManagement.Models.StockType", "StockType")
                        .WithMany()
                        .HasForeignKey("StockTypeId");

                    b.Navigation("StockType");
                });

            modelBuilder.Entity("WebInvManagement.Models.User", b =>
                {
                    b.HasOne("WebInvManagement.Models.UserRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebInvManagement.Models.WarehouseProductionStock", b =>
                {
                    b.HasOne("WebInvManagement.Models.ProductionStock", "ProductionStock")
                        .WithMany("WarehouseProductionStocks")
                        .HasForeignKey("ProductionStockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebInvManagement.Models.Warehouse", "Warehouse")
                        .WithMany("WarehouseProductionStocks")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductionStock");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("WebInvManagement.Models.XYZGroup", b =>
                {
                    b.HasOne("WebInvManagement.Models.IMStrategy", "Strategy")
                        .WithMany()
                        .HasForeignKey("StrategyId");

                    b.Navigation("Strategy");
                });

            modelBuilder.Entity("WebInvManagement.Models.ProductionStock", b =>
                {
                    b.Navigation("WarehouseProductionStocks");
                });

            modelBuilder.Entity("WebInvManagement.Models.Warehouse", b =>
                {
                    b.Navigation("WarehouseProductionStocks");
                });
#pragma warning restore 612, 618
        }
    }
}
