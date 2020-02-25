﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CapstonePracticeLibrary.Models
    {
    public class Vendor
        {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Code { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        [StringLength(30)]
        [Required]
        public string Address { get; set; }
        [StringLength(30)]
        [Required]
        public string City { get; set; }
        [StringLength(02)]
        [Required]
        public string State { get; set; }
        [StringLength(05)]
        [Required]
        public string Zip { get; set; }
        [StringLength(12)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }

        public Vendor() { }
        }
    }
