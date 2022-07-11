using Shop.Interfaces;
using Shop.Pages.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car { Name="Tesla", Price=45000,IsFavorite=true,Available=true,Category=_categoryCars.AllCategories.First() ,Img="https://images.unsplash.com/photo-1617704548623-340376564e68?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1470&q=80"},
                    new Car { Name="BMW", Price=15000,IsFavorite=false,Available=true,Category=_categoryCars.AllCategories.Last() ,Img="https://scontent.fbeg2-1.fna.fbcdn.net/v/t31.18172-8/11043160_815807355160500_577488463414178537_o.jpg?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qBnjKe8qQbAAX_THIK6&_nc_ht=scontent.fbeg2-1.fna&oh=00_AT9mFNhpQF3YCWOlTOSqguGzECJbE1UsvfCbvZvCjjIH2g&oe=62F0FBE8"},
                    new Car { Name="Ford", Price=25000,IsFavorite=true,Available=true,Category=_categoryCars.AllCategories.Last() },
                    new Car { Name="Nissan", Price=12000,IsFavorite=false,Available=true,Category=_categoryCars.AllCategories.Last() },
                    new Car { Name="Opel", Price=11000,IsFavorite=true,Available=true,Category=_categoryCars.AllCategories.Last() },

                };
            } 
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}
