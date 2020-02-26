﻿using CapstonePracticeLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CapstonePracticeLibrary.NewFolder
    {
    public class User
        {
       
        public int Id { get; set; }
        public string Username { get; set; }
        
        public string Password { get; set; }
       
        public string Firstname { get; set; }
        
        public string Lastname { get; set; }
       
        public string Phone { get; set; }
        
        public string Email { get; set; }
        public bool IsReviewer { get; set; }
        public bool IsAdmin { get; set; }

        public override string ToString()
            {
            return $"{Id}/{Username}/{Password}/{Firstname}/{Lastname}/{Phone}/{Email}/{IsReviewer}/{IsAdmin}";
            }
        public virtual List<Request> Requests { get; set; }
        public User() {}
      
        }
    }
