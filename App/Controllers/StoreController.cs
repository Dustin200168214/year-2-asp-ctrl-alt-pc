using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.Models;

namespace App.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            // Make a list of temporary products
            var products = new List<Product>();
            for (var i = 1; i <= 10; i++){
                products.Add(new Product {
                    Name = "Product" + i.ToString()
                });
            }

            return View(products);
        }
        public IActionResult Details(string product)
        {
            // Add product to our view bag container
            ViewBag.product = product;
            return View();
        }
    }
}