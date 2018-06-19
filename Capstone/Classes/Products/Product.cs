﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; private set; }
        public string Category { get; set; }

        public Product(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }




}
