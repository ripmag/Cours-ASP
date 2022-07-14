using Microsoft.EntityFrameworkCore;
using Shop.Interfaces;
using Shop.Models;
using Shop.Pages.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent _appDBContent;
        public CarRepository(AppDBContent appDBContent)
        {
            this._appDBContent = appDBContent;
            
        }

        public IEnumerable<Car> Cars => _appDBContent.Car.Include(c => c.Category);
        public IEnumerable<Car> GetCars => _appDBContent.Car.Where(a => a.Available);

        public IEnumerable<Car> getFavCars => _appDBContent.Car.Where(p => p.IsFavorite);

        public Car getObjectCar(int carId)
        {
           return _appDBContent.Car.FirstOrDefault(p => p.Id == carId);
            
        }
    }
}
