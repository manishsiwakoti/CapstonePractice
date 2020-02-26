﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CapstonePracticeLibrary.Models
    {
    public class Vendor
        {
        
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        public string Name { get; set; }
       
        public string Address { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }
       
        public string Zip { get; set; }
       
        public string Phone { get; set; }
        
        public string Email { get; set; }

        public virtual List<Product> Products { get; set; }
        public Vendor() { }
        }
    }
