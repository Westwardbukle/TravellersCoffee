using System.Collections.Generic;
using Travellers_Coffee.Data.interfaces;
using Travellers_Coffee.Data.Models;

namespace Travellers_Coffee.Data.Repository
{
    public class CategoryRepository : ICoffeCategory
    {
        private readonly AppDbContent appDbContent;

        public CategoryRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }


        public IEnumerable<Category> allCategories => appDbContent.Category;
    }
}