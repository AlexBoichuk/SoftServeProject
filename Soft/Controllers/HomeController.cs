using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Services;

namespace Soft.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        private IProductService _productService;


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View(_productService.GetAll().ToList());
        }


        protected override void Dispose(bool disposing)
        {
            _productService.Dispose();
            base.Dispose(disposing);
        }

    }
}
