using System;
using System.Collections.Generic;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocs
{
    public class MockCategory : ICarsCategory
    {
        public MockCategory()
        {
        }

        public IEnumerable<Category> AllCategorys
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Электромобили", Desc = "Современный вид транспорта" },
                    new Category{CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего сгорания" }
                };
            }
        }
    }
}
