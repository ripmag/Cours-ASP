using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shop.Pages.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Models
{
    public class ShopCard
    {
        private readonly AppDBContent appDBContent;
        public ShopCard(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;

        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }
        public static ShopCard GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var content =service.GetService<AppDBContent>();
            string shopCardID = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", shopCardID);
            return new ShopCard(content) { ShopCartId = shopCardID };
        }
        public void AddCart(Car car )
        {
            this.appDBContent.ShopCartItem.Add(new ShopCartItem { ShopCartID = ShopCartId, Car = car, Price = car.Price });
            appDBContent.SaveChanges();
        }
        public List<ShopCartItem> GetShopItems()
        {
            return appDBContent.ShopCartItem.Where(c => c.ShopCartID == ShopCartId).Include(s => s.Car).ToList();
        }

    }
}
