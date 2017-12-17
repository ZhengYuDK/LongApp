using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LongApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LongApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        // Return a view 
        public ViewResult List()
        {
            return View(_productRepository.Products);
        }

        // Return an action
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}