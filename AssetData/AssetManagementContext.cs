using AssetData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AssetData
{
  public class AssetManagementContext : DbContext
  {
    public AssetManagementContext(DbContextOptions options) : base(options) { }

    public DbSet<Asset> Assets { get; set; } 
    public DbSet<AssetStatus> AssetStatuses { get; set; }
    public DbSet<Attachments> Attachments { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Condition> Conditions { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<OwnershipHistory> OwnershipHistories { get; set; }
    public DbSet<Repair> Repairs { get; set; }

  }
}
