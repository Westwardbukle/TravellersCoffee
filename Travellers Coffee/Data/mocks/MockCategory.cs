using System.Collections.Generic;
using Travellers_Coffee.Data.interfaces;
using Travellers_Coffee.Data.Models;

namespace Travellers_Coffee.Data.mocks
{
    public class MockCategory : ICoffeCategory
    {
        public IEnumerable<Category> allCategories
        {
            get
            {
                return new List<Category>
                {
                    
                };
            }
        }
    }
}