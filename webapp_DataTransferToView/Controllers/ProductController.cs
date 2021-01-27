using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapp_DataTransferToView.Models;

namespace webapp_DataTransferToView.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = Product.ProductList.Take(10);
            return View(model: products); //send data to model 
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}