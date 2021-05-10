using System.Collections.Generic;
using System.Linq;
using Travellers_Coffee.Data.interfaces;
using Travellers_Coffee.Data.Models;

namespace Travellers_Coffee.Data.mocks
{
    public class MockCoffee : IAllProducts
    {
        private readonly ICoffeCategory _categoryCoffee=new MockCategory();
        public IEnumerable<Coffe> Coffes
        {
            get
            {
                return new List<Coffe>
                {
                    
                };
            }
            
        }

        public IEnumerable<Coffe> getFavCoffe { get; set; }
       
        public Coffe getObjectCoffe(int coffeId)
        {
            throw new System.NotImplementedException();
        }
    }
}