using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LongApp.Models;
using LongApp.ViewModels;
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
            var viewModel = new ProductListViewModel();
            viewModel.Products = _productRepository.Products;
            viewModel.CurrentCategory = _categoryRepository.Categories.FirstOrDefault();

            return View(viewModel);
        }

        // Return an action
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}