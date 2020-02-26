using CapstonePracticeLibrary.Models;
using CapstonePracticeLibrary.NewFolder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstonePracticeLibrary
    {
    public class AppDbContext : DbContext 
        {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestLine> RequestLines { get; set; }
        public AppDbContext () { }
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
            {
            if(!builder.IsConfigured)
                {
                builder.UseLazyLoadingProxies();
                var connStr = @"server=localhost\sqlexpress;database=CapstonePracticeDb;trusted_connection=true;";
                builder.UseSqlServer(connStr);
                }
            }
        protected override void OnModelCreating(ModelBuilder model)
            {
            model.Entity<User>(e =>
            {
                e.ToTable("Users");
                e.HasKey(x => x.Id);
                e.Property(x => x.Username).HasMaxLength(30).IsRequired();
                e.Property(x => x.Password).HasMaxLength(30).IsRequired();
                e.Property(x => x.Firstname).HasMaxLength(30).IsRequired();
                e.Property(x => x.Lastname).HasMaxLength(30).IsRequired();
                e.Property(x => x.Phone).HasMaxLength(12);
                e.Property(x => x.Email).HasMaxLength(255);
                e.Property(x => x.IsReviewer);
                e.Property(x => x.IsAdmin);
                e.HasIndex(x => x.Username).IsUnique();
            });
            model.Entity<Vendor>(e =>
            {
                e.ToTable("Vendors");
                e.HasKey(x => x.Id);
                e.Property(x => x.Code).HasMaxLength(30).IsRequired();
                e.Property(x => x.Name).HasMaxLength(30).IsRequired();
                e.Property(x => x.Address).HasMaxLength(30).IsRequired();
                e.Property(x => x.City).HasMaxLength(30).IsRequired();
                e.Property(x => x.State).HasMaxLength(2).IsRequired();
                e.Property(x => x.Zip).HasMaxLength(5).IsRequired();
                e.Property(x => x.Phone).HasMaxLength(12);
                e.Property(x => x.Email).HasMaxLength(255);
                e.HasIndex(x => x.Code).IsUnique();
            });
            model.Entity<Product>(e => {
                e.ToTable("Products");
                e.HasKey(x => x.Id);
                e.Property(x => x.PartNbr).HasMaxLength(30).IsRequired();
                e.Property(x => x.Name).HasMaxLength(30).IsRequired();
                e.Property(x => x.Price).HasColumnType("decimal(11, 2)");
                e.Property(x => x.Unit).HasMaxLength(30).IsRequired();
                e.Property(x => x.PhotoPath).HasMaxLength(255);
                e.HasIndex(x => x.PartNbr).IsUnique();
                e.HasOne(x => x.Vendor).WithMany(x => x.Products)
                                     .HasForeignKey(x => x.VendorId)
                                     .OnDelete(DeleteBehavior.Restrict);
               
                                     
            });
            }
        
        }
    }
