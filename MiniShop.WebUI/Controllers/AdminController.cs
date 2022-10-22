using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniShop.Business.Abstract;
using MiniShop.Entity;
using MiniShop.WebUI.Models;

namespace MiniShop.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;

        public AdminController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult ProductList()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult ProductCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProductCreate(ProductModel product)
        {
            //Gelen productı alıp EF Core aracılığıyla veritabanına kaydetmem lazım gerekiyor
            var entity = new Product(){
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Url = product.Url,
                ImageUrl = product.ImageUrl
            };
            _productService.Create(entity);
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public IActionResult ProductEdit(int id)
        {
            var entity =_productService.GetById(id);
            if(entity == null)
            {
                return NotFound();
            }  
            
            var productModel = new ProductModel(){
                ProductId =entity.ProductId,
                Name = entity.Name,
                Url = entity.Url,
                Price = entity.Price,
                ImageUrl = entity.ImageUrl,
                Description = entity.Description
            };
             return View(productModel);
        }
         [HttpPost]
        public IActionResult ProductEdit(ProductModel productModel)
        {
            var entity = _productService.GetById(productModel.ProductId);
            if (entity == null)
            {
                return NotFound();
            }
            entity.Name = productModel.Name;
            entity.Price = productModel.Price;
            entity.ImageUrl = productModel.ImageUrl;
            entity.Description = productModel.Description;

            _productService.Update(entity);

            return RedirectToAction("ProductList");
        }
        
    }
}