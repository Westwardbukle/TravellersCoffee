using Microsoft.AspNetCore.Mvc;
using Travellers_Coffee.Data.interfaces;
using Travellers_Coffee.ViewModels;

namespace Travellers_Coffee.Controllers
{
    public class CoffeeController :Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly ICoffeCategory _allCategories;

        public CoffeeController(IAllProducts iAllProducts, ICoffeCategory iCoffeCat)
        {
            _allProducts = iAllProducts;
            _allCategories = iCoffeCat;
        }

        public ViewResult List()
        {
            CoffeeListViewModel obj = new CoffeeListViewModel();
            obj.allCoffes = _allProducts.Coffes;
            obj.currCategory = "Товары";
            return View(obj);
        }
        
    }
}