using Microsoft.AspNetCore.Mvc;
using Shop.Interfaces;
using Shop.Models;

namespace Shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders orders;
        private readonly ShopCard shopCart;
        public OrderController(IAllOrders orders, ShopCard shopCart)
        {
            this.orders = orders;
            this.shopCart = shopCart;
        }
        public IActionResult ChekOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ChekOut(Order order)
        {
            shopCart.ListShopItems = shopCart.GetShopItems();
            if(shopCart.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У Вас должны быть товары!");
            }
            if (ModelState.IsValid)
            {
                orders.createOrder(order);
                return RedirectToAction("Complete");
            }            
            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно совершен";
            return View();

        }
    }
}
