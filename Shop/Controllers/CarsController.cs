using Microsoft.AspNetCore.Mvc;
using Shop.Interfaces;

using Microsoft.Extensions.Logging;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategory;
        public CarsController(IAllCars allCars, ICarsCategory allCategory)
        {
            _allCars = allCars;
            _allCategory = allCategory;
        }
        public ViewResult List()        
        {
            //return View();
            //var cars = _allCars.Cars;
            ViewBag.Title = "Страница с Авто!";
            CarsListViewModels obj = new CarsListViewModels();
            obj.AllCars = _allCars.Cars;
            obj.currCategory = "Автомобоили";
            return View(obj);
        }
    }
}
