using Shop.Interfaces;
using Shop.Pages.Models;
using System.Collections.Generic;

namespace Shop.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Электромобили", Desc = "Современный вид транспорта" },
                    new Category { CategoryName = "Классические авто", Desc = "Машины с двигателем внутреннего сгорания" }
                };
            }
        }
    }
}
