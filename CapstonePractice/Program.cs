using CapstonePracticeLibrary;
using CapstonePracticeLibrary.Models;
using CapstonePracticeLibrary.NewFolder;
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
            AddVendor(context);
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
            foreach(var u in users)
                {
                Console.WriteLine(u);
                }
            }
        static void AddVendor(AppDbContext context)
            {
            var vendor = new Vendor
                {
                Id = 0,
                Code = "AMZ",
                Name = "AMAZON INC",
                Address = "123 Parkway dr",
                City = "Cincinnati",
                State = "OH",
                Zip = "45012"
                
                };
            }
        }

    }
