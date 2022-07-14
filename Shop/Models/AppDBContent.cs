using Microsoft.EntityFrameworkCore;
using Shop.Pages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Data.Entity;
//using System.Data.Entity.Core;

namespace Shop.Models
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }


    }
}
