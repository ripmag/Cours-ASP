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
using Shop.Pages.Models;

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
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)        
        {
            string _category = category;
            IEnumerable < Car > cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(_category))
            {
                cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro",category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Электромобили")).OrderBy(i => i.Id);
                    currCategory = "Электромобили";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Классические авто")).OrderBy(i => i.Id);
                    currCategory = "Классические авто";
                }
                
                
            }
            //return View();
            //var cars = _allCars.Cars;
            var carObj = new CarsListViewModels
            {
                AllCars = cars,
                currCategory = currCategory
            };
            return View(carObj);
        }
    }
}
