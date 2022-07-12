using Shop.Pages.Models;
using System.Collections.Generic;

namespace Shop.ViewModels
{
    public class CarsListViewModels
    {
        public IEnumerable<Car> AllCars { get; set; }
        public string currCategory { get; set; }
    }
}
