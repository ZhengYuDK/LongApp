using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set;  }
    }
}
