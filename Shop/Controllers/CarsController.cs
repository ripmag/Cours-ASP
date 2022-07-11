using Microsoft.AspNetCore.Mvc;
using Shop.Interfaces;

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
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
