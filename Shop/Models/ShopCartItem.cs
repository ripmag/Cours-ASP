﻿using Shop.Pages.Models;

namespace Shop.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public int Price { get; set; }
        public string ShopCartID { get; set; }

    }
}
