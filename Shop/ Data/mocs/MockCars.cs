using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocs
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory carsCategory = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { name = "Tesla Model S",
                              shortDisc = "Быстрый и современный автомобиль.",
                              longDisc = "Быстрый электроавтомобиль подходит как для поездок в городе ,так и для того что бы показать кто тут главный на автобане. ",
                              img = "/img/tesla.jpg",
                              price = 45000,
                              isFavorite = true,
                              available = true,
                              Category = carsCategory.AllCategorys.First()
                    },
                    new Car { name = "BMW M3",
                              shortDisc = "Спортивный автомобиль",
                              longDisc = "Быстрая машина которая идеально подходит для гонок на автобане от компании BMW.",
                              img = "/img/BMW.jpg",
                              price = 25000,
                              isFavorite = true,
                              available = true,
                              Category = carsCategory.AllCategorys.Last()
                    },
                    new Car{name="Ford Mustang",
                            shortDisc="Быстрый автомобиль",
                            longDisc="Быстрый автомобиль для быстрых и успешных людей от компании Ford.",
                            img = "/img/Ford Mustang.jpg",
                            price=40250,
                            isFavorite=true,
                            available=true,
                            Category= carsCategory.AllCategorys.Last()
                    },
                    new Car{name="BMW I3",
                            shortDisc="Быстрая зарядка и экономный",
                            longDisc="Экономный автомобиль идеально подходящий для поездок по европескому городу от компании BMW.",
                            img="/img/BMW-i3.jpg",
                            price=38000,
                            isFavorite=false,
                            available=true,
                            Category= carsCategory.AllCategorys.First()
                    },
                    new Car{name="Mercedes-Benz C-Klasse",
                            shortDisc="Быстрый и комфортный автомобиль",
                            longDisc="Спортивный автомобиль бизнес класса, только для успешных автолюбителей.",
                            img="/img/merzedes.jpg",
                            price=62000,
                            isFavorite=true,
                            available=false,
                            Category=carsCategory.AllCategorys.Last()
                    }

                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
