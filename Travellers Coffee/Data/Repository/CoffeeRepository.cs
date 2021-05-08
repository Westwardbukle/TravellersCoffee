using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Travellers_Coffee.Data.interfaces;
using Travellers_Coffee.Data.Models;

namespace Travellers_Coffee.Data.Repository
{
    public class CoffeeRepository : IAllProducts
    {
        private readonly AppDbContent appDbContent;

        public CoffeeRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Coffe> Coffes => appDbContent.Coffe.Include(c => c.Category);
        
        public IEnumerable<Coffe> getFavCoffe => appDbContent.Coffe.Where(p => p.isFavorite)
            .Include(c => c.Category);
        
        public Coffe getObjectCoffe(int coffeId) => appDbContent.Coffe.FirstOrDefault(p =>p.id==coffeId);
    }
}