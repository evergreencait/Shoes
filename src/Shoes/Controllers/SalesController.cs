using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shoes.Models;

namespace Sales.Controllers
{
    public class SalesController : Controller
    {
        private ShoesDbContext db = new ShoesDbContext();
        public IActionResult Index()
        {
            return View(db.Sales.ToList());
        }
        
        public IActionResult Details(int id)
        {
            Sale thisSale = db.Sales.FirstOrDefault(sales => sales.SaleId == id);
            return View(thisSale);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string newShoe, int newPrice, string newImage, string newComment)
        {
            Sale newSale = new Sale(newShoe, newPrice, newImage, newComment);
            db.Sales.Add(newSale);
            db.SaveChanges(); 
            return Json(newSale);
        }

        public IActionResult Edit(int id)
        {
            var thisSale = db.Sales.FirstOrDefault(sales => sales.SaleId == id);
            return View(thisSale);
        }

        [HttpPost]
        public IActionResult Edit(Sale sale)
        {
            db.Entry(sale).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisSale = db.Sales.FirstOrDefault(sales => sales.SaleId == id);
            return View(thisSale);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisSale = db.Sales.FirstOrDefault(sales => sales.SaleId == id);
            db.Sales.Remove(thisSale);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
