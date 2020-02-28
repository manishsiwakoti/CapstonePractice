using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace CapstonePracticeLibrary.Models
    {
    public class RequestLine

        {

        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; } = 1;

        [JsonIgnore]
        public virtual Product Product { get; set; }
        public virtual Request Request { get; set; }

        public override string ToString() {return $"{Id}/{RequestId}/{ProductId}/{Quantity}";}
            
            
        public RequestLine() { }
        }
    }
