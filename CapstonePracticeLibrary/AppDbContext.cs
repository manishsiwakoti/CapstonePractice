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
        }
    }
