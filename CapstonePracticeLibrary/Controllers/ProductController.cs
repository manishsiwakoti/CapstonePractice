using CapstonePracticeLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapstonePracticeLibrary.Controllers
    {
    public class ProductController
        {
        private AppDbContext context = new AppDbContext();
        public IEnumerable<Product> GetAllProduct()
            {
            return context.Products.ToList();
            }
        public Product GetByPK(int id)
            {
            if (id < 1) throw new Exception("Id must be Greater than zero");
            return context.Products.Find(id);
            }
        public Product Insert(Product product)
            {
            if (product == null) throw new Exception("Vendor cannot be null");
            context.Products.Add(product);
            try
                {
                context.SaveChanges();
                }
            catch (DbUpdateException ex)
                {
                throw ex;
                }
                {
                return product;
                }
            }
        public  Product Update(Product product)
            {
            if (product == null) throw new Exception("Product cannot be null");
            context.Entry(product).State = EntityState.Modified;
            try
                {
                context.SaveChanges();
                }
            catch(DbUpdateException ex)
                {
                throw ex; //new Exception("PartNbr must be unique");
                }
            catch (Exception)
                {
                throw new Exception("PartNbr must be unique");
                }
            return product;
            }
            
    }
}