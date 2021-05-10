using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Travellers_Coffee.Data.Models
{
    public class ShopCart
    {
        private readonly AppDbContent _appDbContent;

        public ShopCart(AppDbContent appDbContent)
        {
            this._appDbContent = appDbContent;
        }
        
        
        public string ShopCartId { get; set; }
        
        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            
            session.SetString("CartId",shopCartId);

            return new ShopCart(context) {ShopCartId = shopCartId};
        }

        public void AddToCart(Coffe coffe)
        {
            _appDbContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                coffe = coffe,
                price = coffe.price
            });

            _appDbContent.SaveChanges();

        }

        public List<ShopCartItem> GetShopItems()
        {
            return _appDbContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId)
                .Include(s => s.coffe).ToList();
        }
        
    }
    
}