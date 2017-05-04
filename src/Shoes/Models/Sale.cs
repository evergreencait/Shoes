using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shoes.Models
{
    [Table("Sales")]
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public string ShoeName { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string Comment { get; set; }
        public virtual Inventory Inventory { get; set; }

        public Sale()
        {

        }

        public Sale(string _shoename, int _price, string _image, string _comment, int _id = 0)
        {
            ShoeName = _shoename;
            Price = _price;
            Image = _image;
            Comment = _comment;
        }
        
    }
}
