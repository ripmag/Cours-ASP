using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Pages.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Models
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content) 
        {
            
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car { Name = "Tesla", Price = 45000, IsFavorite = true, Available = true, Category = Categories["Электромобили"], Img = "https://images.unsplash.com/photo-1617704548623-340376564e68?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1470&q=80" },
                    new Car { Name = "BMW", Price = 15000, IsFavorite = false, Available = true, Category = Categories["Классические авто"], Img = "https://scontent.fbeg2-1.fna.fbcdn.net/v/t31.18172-8/11043160_815807355160500_577488463414178537_o.jpg?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qBnjKe8qQbAAX_THIK6&_nc_ht=scontent.fbeg2-1.fna&oh=00_AT9mFNhpQF3YCWOlTOSqguGzECJbE1UsvfCbvZvCjjIH2g&oe=62F0FBE8" },
                    new Car { Name = "Ford", Price = 25000, IsFavorite = true, Available = true, Category = Categories["Классические авто"], Img = "https://imgd.aeplcdn.com/1056x594/cw/ec/40369/Ford-EcoSport-Right-Front-Three-Quarter-159249.jpg?wm=1&q=75" },
                    new Car { Name = "Nissan", Price = 12000, IsFavorite = false, Available = true, Category = Categories["Классические авто"], Img = "https://cp-avtomir.ru/photo_bank/render/nissan/x-trail_t32g/xe_%D0%BA%D1%80%D0%BE%D1%81%D1%81%D0%BE%D0%B2%D0%B5%D1%80/QM1_1.png?_ga=2.229825054.307143356.1657571861-1858586992.1657571855" },
                    new Car { Name = "Opel", Price = 11000, IsFavorite = true, Available = true, Category = Categories["Классические авто"], Img = "/img/opel.jpeg" }

                    );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories 
        {
            get {
                if (category == null) { 
                    var _list = new Category[]
                    {

                        new Category { CategoryName = "Электромобили", Desc = "Современный вид транспорта" },
                        new Category { CategoryName = "Классические авто", Desc = "Машины с двигателем внутреннего сгорания" }
                    };
                category = new Dictionary<string, Category>();
                foreach (Category el in _list)
                    category.Add(el.CategoryName, el);
            }
                return category;
            }

        }
    }
}
