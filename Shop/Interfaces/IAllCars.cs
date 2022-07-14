using Shop.Models;
using Shop.Pages.Models;
using System.Collections.Generic;
namespace Shop.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetCars { get; }
        IEnumerable<Car> getFavCars { get; }
        Car getObjectCar (int carId);
    }
}
