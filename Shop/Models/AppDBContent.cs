﻿using Microsoft.EntityFrameworkCore;
using Shop.Pages.Models;
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

    }
}
