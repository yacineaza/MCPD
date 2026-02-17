using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice4.Models;
using Exercice4.Services;
using Microsoft.AspNetCore.Mvc;


namespace Exercice4.Controllers
{
    public class ProductController : Controller
    {
        private ProductService _service;

        public ProductController()
        {
            _service = new ProductService();
        }


        public IActionResult Index()
        {
            List<Product> products = _service.GetAll();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            Product product = _service.GetById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

     
        public IActionResult Filter(string category, double? maxPrice)
        {
            List<Product> products = _service.Filter(category, maxPrice);
            return View(products);
        }
    }
}
