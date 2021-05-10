
using Microsoft.AspNetCore.Mvc;
using Travellers_Coffee.Data.interfaces;
using Travellers_Coffee.ViewModels;

namespace Travellers_Coffee.Controllers
{
    public class HomeController :Controller
    {
        private readonly IAllProducts _coffeeRepository;

        public HomeController(IAllProducts coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }

        public ViewResult Index()
        {
            var homeCoffee = new HomeViewModel
            {
                FavCoffees = _coffeeRepository.getFavCoffe
            };
            return View(homeCoffee);
        }
        
    }
}