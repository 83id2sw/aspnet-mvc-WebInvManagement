﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebInvManagement.Models;

namespace WebInvManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // many to many [Warehouse has Stock]
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WarehouseProductionStock>()
                .HasKey(wp => new { wp.WarehouseId, wp.ProductionStockId });

            modelBuilder.Entity<WarehouseProductionStock>()
                .HasOne(wp => wp.Warehouse)
                .WithMany(w => w.WarehouseProductionStocks)
                .HasForeignKey(wp => wp.WarehouseId);

            modelBuilder.Entity<WarehouseProductionStock>()
                .HasOne(wp => wp.ProductionStock)
                .WithMany(p => p.WarehouseProductionStocks)
                .HasForeignKey(wp => wp.ProductionStockId);

            // many to many [ABC has Stock]
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ABCProductionStock>()
                .HasKey(wp => new { wp.ABCId, wp.ProductionStockId });

            modelBuilder.Entity<ABCProductionStock>()
                .HasOne(wp => wp.ABCGroup)
                .WithMany(w => w.ABCProductionStocks)
                .HasForeignKey(wp => wp.ABCId);

            modelBuilder.Entity<ABCProductionStock>()
                .HasOne(wp => wp.ProductionStock)
                .WithMany(p => p.ABCProductionStocks)
                .HasForeignKey(wp => wp.ProductionStockId);

            // many to many [XYZ has Stock]
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<XYZProductionStock>()
                .HasKey(wp => new { wp.XYZId, wp.ProductionStockId });

            modelBuilder.Entity<XYZProductionStock>()
                .HasOne(wp => wp.XYZGroup)
                .WithMany(w => w.XYZProductionStocks)
                .HasForeignKey(wp => wp.XYZId);

            modelBuilder.Entity<XYZProductionStock>()
                .HasOne(wp => wp.ProductionStock)
                .WithMany(p => p.XYZProductionStocks)
                .HasForeignKey(wp => wp.ProductionStockId);

            // many to many [StockMovement has ProductionStock]
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StockMovementProductionStock>()
                .HasKey(wp => new { wp.StockMovementId, wp.ProductionStockId });

            modelBuilder.Entity<StockMovementProductionStock>()
                .HasOne(wp => wp.StockMovement)
                .WithMany(w => w.StockMovementProductionStocks)
                .HasForeignKey(wp => wp.StockMovementId);

            modelBuilder.Entity<StockMovementProductionStock>()
                .HasOne(wp => wp.ProductionStock)
                .WithMany(p => p.StockMovementProductionStocks)
                .HasForeignKey(wp => wp.ProductionStockId);

            // many to many [Operation has ProductionStock]
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OperationProductionStock>()
                .HasKey(wp => new { wp.OperationId, wp.ProductionStockId });

            modelBuilder.Entity<OperationProductionStock>()
                .HasOne(wp => wp.Operation)
                .WithMany(w => w.OperationProductionStocks)
                .HasForeignKey(wp => wp.OperationId);

            modelBuilder.Entity<OperationProductionStock>()
                .HasOne(wp => wp.ProductionStock)
                .WithMany(p => p.OperationProductionStocks)
                .HasForeignKey(wp => wp.ProductionStockId);
        }

        public DbSet<StockType> StockTypes { get; set; }
        public DbSet<ProductionStock> ProductionStocks { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseProductionStock> WarehouseProductionStocks { get; set; }
        public DbSet<ABCProductionStock> ABCProductionStocks { get; set; }
        public DbSet<XYZProductionStock> XYZProductionStocks { get; set; }
        public DbSet<StockMovementProductionStock> StockMovementProductionStocks { get; set; }
        public DbSet<ABCGroup> ABCGroups { get; set; }
        public DbSet<XYZGroup> XYZGroups { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }
        public DbSet<IMStrategy> IMStrategys { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
