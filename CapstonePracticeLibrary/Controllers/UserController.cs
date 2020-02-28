using CapstonePracticeLibrary.NewFolder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapstonePracticeLibrary.Controllers
    {
    public class UserController
        {
        private AppDbContext context = new AppDbContext();

        public User Login(string username, string password)
            {
            return context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            }

        public List<User> GetAll()
            {
            return context.Users.ToList();
            }
        public User GetByPK(int Id)
            {
            if (Id < 1) throw new Exception("Id must be Greater than zero");
            return context.Users.Find(Id);
            }
        public User Insert(User user)
            {
            if (user == null) throw new Exception("User cannot be null");
            //edit checking here
            context.Users.Add(user);
            try
                {
                context.SaveChanges();
                }
            catch (DbUpdateException ex)
                {
                throw new Exception("Username must be unique", ex);

                }
            catch (Exception ex)
                {
                throw ex;
                }
            return user;
            }
        public bool Update(int id, User user)
            {
            if (user == null) throw new Exception("User cannot be null");
            if (id != user.Id) throw new Exception("Id and User.Id must match");
            context.Entry(user).State = EntityState.Modified;
            try
                {
                context.SaveChanges();
                }
            catch (DbUpdateException ex)
                {
                throw new Exception("Username must be unique", ex);

                }
            catch (Exception ex)
                {
                throw ex;
                }
            return true;
            }
        public bool Delete(int id)
            {
            if (id <= 0) throw new Exception("Id must be Greater than zero");
            var user = context.Users.Find(id);
            return Delete(user);
            }
        public bool Delete(User user)
            {
            context.Users.Remove(user);
            context.SaveChanges();
            return true;

            }
        }

    }