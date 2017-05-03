using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Shoes.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public string ShoeName { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string Comment { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
