﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Products
    {
        public int ProductId { get; set; }

        public string ProductCategory { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductPrice { get; set; }

        public string ProductQuantity { get; set; }
    }
}
