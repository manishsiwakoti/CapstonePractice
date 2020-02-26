﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CapstonePracticeLibrary.Models
    {
    public class RequestLine

        {
        
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; } = 1;

        public virtual Product Product { get; set; }
        public RequestLine() { }
        }
    }
