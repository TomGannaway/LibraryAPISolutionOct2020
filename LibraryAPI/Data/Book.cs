﻿using LibraryAPI.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set;  }
        public DateTime AddedToInventory { get; set; }
        public bool IsInInventory { get; set; }
    }
}