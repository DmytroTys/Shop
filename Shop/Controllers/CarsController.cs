using System;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModel;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        public readonly IAllCars _allCars;
        public readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iAllCategory)
        {
            _allCars = iAllCars;
            _allCategories = iAllCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.Allcars = _allCars.Cars;
            obj.carCategory = " Автомобили";
            return View(obj);
        }
    }
}
