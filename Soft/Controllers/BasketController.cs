using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Services;
using DataLayer.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Soft.Controllers
{
    public class BasketController : Controller
    {
        private IOrderService _orderService;
        public BasketController(IOrderService orderServ)
        {
            _orderService = orderServ;
        }

        [HttpPost]
        public IActionResult Add(int idProduct, int quantity)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Identity.GetUserId();

                _orderService.AddProduct(idProduct, quantity, userId);
            }

            return RedirectToAction("Products", "Home");
        }


        public IActionResult Basket()
        {
            string userId = User.Identity.GetUserId();
            Order result = _orderService.GetBasket(userId);
            if (result == null)
            {
                return View("EmptyBasket", "Basket");
            }
            else
            {
                return View(result);
            }
        }


        [HttpPost]
        public IActionResult Buy(int idOrder)
        {
            string userId = User.Identity.GetUserId();
            _orderService.Buy(idOrder, userId);
            return View("EmptyBasket", "Basket");
        }

        public IActionResult MyOrders()
        {
            string userId = User.Identity.GetUserId();
            List<Order> result = _orderService.GetAllOrders(userId).ToList();
            if (result.Count == 0)
            {
                return View("EmptyOrder", "Basket");
            }
            else
            {
                return View(result);
            }
        }


        protected override void Dispose(bool disposing)
        {
            _orderService.Dispose();
            base.Dispose(disposing);
        }
    }
}