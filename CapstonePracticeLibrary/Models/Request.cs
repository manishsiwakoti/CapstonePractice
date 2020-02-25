﻿using CapstonePracticeLibrary.NewFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CapstonePracticeLibrary.Models
    {
    public class Request

        {
        [Key]
        public int Id { get; set; }
        [StringLength(80)]
        [Required]
        public string Description { get; set; }
        [StringLength(80)]
        [Required]
        public string Justification { get; set; }
        [StringLength(80)]
        public string RejectionReason { get; set; }
        [StringLength(20)]
        [Required]
        public string DeliveryMode { get; set; }
        [StringLength(10)]
        [Required]
        public string Status { get; set; }
        public Decimal Total { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }

        }
    }
