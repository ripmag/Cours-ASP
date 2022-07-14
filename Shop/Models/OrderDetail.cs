﻿using Shop.Pages.Models;

namespace Shop.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CarID { get; set; }
        public uint Price { get; set; }
        public virtual Car Car { get; set; }
        public virtual Order Order { get; set; }

        
    }
}
