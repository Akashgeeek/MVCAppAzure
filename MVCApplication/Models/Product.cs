using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string? Name { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
