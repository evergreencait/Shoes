using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shoes.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public int Revenue { get; set; }
        public Inventory(int stock, int revenue, int id = 0)
        {
            Stock = stock;
            Revenue = revenue;
            Id = id; 
        }
    }
}
