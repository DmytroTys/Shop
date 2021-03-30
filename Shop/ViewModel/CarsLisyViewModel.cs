using System;
using System.Collections.Generic;
using Shop.Data.Models;

namespace Shop.ViewModel
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> Allcars { set; get; }

        public string carCategory { set; get; }
    }
}
