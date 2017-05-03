using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shoes.Models;


namespace Shoes.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult DisplayObject()
        {
            Inventory inventory = new Inventory(600, 7000, 1);
            return Json(inventory);
        }
    }
}
