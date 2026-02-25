using Microsoft.AspNetCore.Mvc;
using Quantify.Services;

namespace Quantify.Controllers
{
    public class ProductsController(ProductService productService) : Controller
    {
        private readonly ProductService _productService = productService;

        public IActionResult ProductList()
        {
            ViewData["Title"] = "Products";

            return View(_productService.GetProducts());
        }
    }
}
