﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationAsp.Net.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Category1 { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
