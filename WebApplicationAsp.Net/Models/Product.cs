using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebApplicationAsp.Net.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Productname { get; set; }
        public int? CatId { get; set; }
        public int? BrandId { get; set; }
        public int? Qte { get; set; }
        public decimal? Price { get; set; }

      

        public virtual Brand Brand { get; set; }
        

        public virtual Category Cat { get; set; }

    }
}
