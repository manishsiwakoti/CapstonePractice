using CapstonePracticeLibrary.NewFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CapstonePracticeLibrary.Models
    {
    public class Request

        {
        
        public int Id { get; set; }
        
        public string Description { get; set; }
       
        public string Justification { get; set; }
       
        public string RejectionReason { get; set; }
       
        public string DeliveryMode { get; set; } = "PickUp";
        
        public string Status { get; set; } = "New";
        public decimal Total { get; set; } = 0;
        public int UserId { get; set; }

        public virtual IEnumerable<RequestLine> RequestLines { get; set; }
        public virtual User User { get; set; }
        public override string ToString() { return $"{Id}/{Description}/{Justification}/{RejectionReason}/{DeliveryMode}/{Status}/{Total}/{UserId}";}
        }
    }
