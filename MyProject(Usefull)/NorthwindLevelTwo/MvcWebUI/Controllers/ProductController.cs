using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class ProductController:Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
       

        public ProductController(IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index(int category)
        {

            var model=new ProductListViewModel
            {
                Products = category>0?_productService.GetByCategory(category) : _productService.GetAll(),
            };

            return View(model);
        }
    }
}
