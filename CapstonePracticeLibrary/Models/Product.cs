using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CapstonePracticeLibrary.Models
    {
    public class Product
        {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string PartNbr { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        
        public decimal Price { get; set; } 
        [StringLength(30)]
        [Required]
        public string Unit { get; set; }
        public string PhotoPath { get; set; }
        public int VendorId { get; set; }

        public virtual Vendor Vendor { get; set; }
        
        public Product() { }

        }
    }
