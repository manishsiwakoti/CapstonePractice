using CapstonePracticeLibrary;
using CapstonePracticeLibrary.Models;
using CapstonePracticeLibrary.NewFolder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CapstonePractice
    {
    class Program
        {
        static void Main(string[] args)
            {
            var context = new AppDbContext();
            //AddUser(context);
            GetAllUsers(context);
            //AddVendor(context);
            GetAllVendors(context);
           //AddProducts(context);
            GetAllProducts(context);


            }
        static void AddUser(AppDbContext context)
            {
            var user = new User
                {
                Id = 0,
                Username = "Maya",
                Password = "456@Maya",
                Firstname = "Maya",
                Lastname = "Chettri",
                //Phone = "814-218-8987",
                //Email = "Manishsiwakoti23@yahoo.com",
                IsReviewer = false,
                IsAdmin = false
                };
            context.Users.Add(user);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected == 0) throw new Exception("Adding Failed!");
            return;

            }
        static void GetAllUsers(AppDbContext context)
            {
            var users = context.Users.ToList();
            foreach (var u in users)
                {
                Console.WriteLine(u);
                }
            }
        static void AddVendor(AppDbContext context)
            {
            var vendor = new Vendor
                {
                Id = 0,
                Code = "Sams",
                Name = "Samsung",
                Address = "5422 DEF Rd",
                City = "Akron",
                State = "OH",
                Zip = "98774"
                };
            context.Vendors.Add(vendor);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected == 0) throw new Exception("Adding Failed!");
            return;
            }
        static void GetAllVendors(AppDbContext context)
            {
            var vendors = context.Vendors.ToList();
            foreach (var v in vendors)
                {
                Console.WriteLine(v);
                }
            }
        static void AddProducts(AppDbContext context)

            
            {
            var p1 = new Product { Id = 0, PartNbr = "ECHO", Name = "Echo", Price = 99.99m, Unit = "1", VendorId = 100 };
            var p2 = new Product { Id = 0, PartNbr = "ECHODOT", Name = "Echo", Price = 39.99m, Unit = "1", VendorId = 200 };
            var p3 = new Product { Id = 0, PartNbr = "ECHOSHOW", Name = "Echo Show", Price = 119.99m, Unit = "1", VendorId = 300 };
            var p4 = new Product { Id = 0, PartNbr = "FIRESTIK", Name = "Fire TV Stick", Price = 49.99m, Unit = "1", VendorId = 400 };
            var p5 = new Product { Id = 0, PartNbr = "FIRETV", Name = "Fire TV Cube", Price = 129.99m, Unit = "1", VendorId = 500 };
            context.Products.AddRange(p1, p2, p3, p4, p5);
            var echo = context.Products.SingleOrDefault(p => p.PartNbr == "ECHO").Id;
            var echodot = context.Products.SingleOrDefault(p => p.PartNbr == "ECHODOT").Id;
            var echoshow = context.Products.SingleOrDefault(p => p.PartNbr == "ECHOSHOW").Id;
            var firestick = context.Products.SingleOrDefault(p => p.PartNbr == "FIRESTIK").Id;
            var firetv = context.Products.SingleOrDefault(p => p.PartNbr == "FIRETV").Id;
            try
                {
                var rowsAffected = context.SaveChanges();
                
                }
            catch(DbUpdateException )
                {
                // throw new Exception //("Failed to Update");
                //Console.WriteLine();
                }
            return ;
            



            }
        static void GetAllProducts(AppDbContext context)
            {
            var products = context.Products.ToList();
            foreach (var p in products)
                {
                Console.WriteLine(p);
                     
            }
        }
       }
                

    }
 
    

        

    
