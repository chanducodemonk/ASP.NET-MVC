﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBindingDemo.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }
    }
}