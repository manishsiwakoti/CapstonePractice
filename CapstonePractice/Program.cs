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
            //AddRequests(context);
            GetAllRequests(context);
            //UpdateUser(context);
            //UpdateRequest(context);
            //AddRequestLines(context);
            GetAllRequestLines(context);
            //DeleteRequestLines(context);
           



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
        static void UpdateUser(AppDbContext context)
            {
            var userPk = 6;
            var user = context.Users.Find(userPk);
            if (user == null) throw new Exception("User not found");
            user.IsReviewer = true;

            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Failed to Update");
            Console.WriteLine("Update Successful");
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
            var p1 = new Product { Id = 0, PartNbr = "ECHO", Name = "Echo", Price = 99.99m, Unit = "1", VendorId = 1 };
            var p2 = new Product { Id = 0, PartNbr = "ECHODOT", Name = "Echo", Price = 39.99m, Unit = "1", VendorId = 2 };
            var p3 = new Product { Id = 0, PartNbr = "ECHOSHOW", Name = "Echo Show", Price = 119.99m, Unit = "1", VendorId = 3 };
            var p4 = new Product { Id = 0, PartNbr = "FIRESTIK", Name = "Fire TV Stick", Price = 49.99m, Unit = "1", VendorId = 4 };
            var p5 = new Product { Id = 0, PartNbr = "FIRETV", Name = "Fire TV Cube", Price = 129.99m, Unit = "1", VendorId = 5 };
            context.Products.AddRange(p1, p2, p3, p4, p5);


            try
                {
                var rowsAffected = context.SaveChanges();
                if (rowsAffected == 0) throw new Exception("Products cannot add");


                }
            catch (DbUpdateException)
                {


                }
            return;

            }
        static void GetAllProducts(AppDbContext context)
            {
            var products = context.Products.ToList();
            foreach (var p in products)
                {
                Console.WriteLine(p);

                }

            }
        static void AddRequests(AppDbContext context)
            {
            var rq1 = new Request { Id = 0, Description = "Sunday", Justification = "ABC", Status = "New", UserId = 1 };
            var rq2 = new Request { Id = 0, Description = "Monday", Justification = "BCD", Status = "New", UserId = 4 };
            var rq3 = new Request { Id = 0, Description = "Tuesday", Justification = "CDE", Status = "New", UserId = 5 };
            var rq4 = new Request { Id = 0, Description = "Wednesday", Justification = "DEF", Status = "New", UserId = 6 };
            var rq5 = new Request { Id = 0, Description = "Thursday", Justification = "EFG", Status = "New", UserId = 7 };
            context.Requests.AddRange(rq1, rq2, rq3, rq4, rq5);
            var rowsAffected = context.SaveChanges();
            Console.WriteLine("Requests Added");
            }
        static void GetAllRequests(AppDbContext context)
            {
            var requests = context.Requests.ToList();
            foreach (var rq in requests)
                {
                Console.WriteLine(rq);
                }

            }
        static void UpdateRequest(AppDbContext context)
            {
            var requestid = 14;

            var request = context.Requests.Find(requestid);
            if (request == null) throw new Exception("Request not found");
            request.Status = "NEW";
            var rowAffected = context.SaveChanges();
            if (rowAffected != 1) throw new Exception("Cannot update Request");
            Console.WriteLine("Successful!");
            }



        static void AddRequestLines(AppDbContext context)
            {
            var rls1 = new RequestLine { Id = 0, RequestId = 10, ProductId = 24 };
            var rls2 = new RequestLine { Id = 0, RequestId = 11, ProductId = 25 };
            var rls3 = new RequestLine { Id = 0, RequestId = 12, ProductId = 26 };
            var rls4 = new RequestLine { Id = 0, RequestId = 13, ProductId = 27 };
            var rls5 = new RequestLine { Id = 0, RequestId = 14, ProductId = 28 };
            context.RequestLines.AddRange(rls1, rls2, rls3, rls4, rls5);
            var rowsAffected = context.SaveChanges();
            Console.WriteLine("Added RequestLines");
            }
        static void GetAllRequestLines(AppDbContext context)
            {
            var requestlines = context.RequestLines.ToList();
            foreach (var rls in requestlines)
                {
                Console.WriteLine(rls);
                }
            }
        static void DeleteRequestLines(AppDbContext context)
            {
            var KeyTODelete = 10;
            var rls = context.RequestLines.Find(KeyTODelete);
            if (rls == null) throw new Exception("RequestLine not Found");
            context.RequestLines.Remove(rls);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 10) throw new Exception("Delete Failed");
            }

        }
    }
                

    
 
    

        

    
