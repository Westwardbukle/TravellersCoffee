using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Travellers_Coffee.Data.interfaces;
using Travellers_Coffee.Data.Models;

using Travellers_Coffee.ViewModels;

namespace Travellers_Coffee.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllProducts _coffeeRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllProducts coffeeRepository, ShopCart shopCart)
        {
            _coffeeRepository = coffeeRepository;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _coffeeRepository.Coffes.FirstOrDefault(i=>i.id==id);
            if (item!=null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
        
    }
}