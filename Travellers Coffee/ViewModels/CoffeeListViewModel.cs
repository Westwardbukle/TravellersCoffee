using System.Collections.Generic;
using Travellers_Coffee.Data.Models;

namespace Travellers_Coffee.ViewModels
{
    public class CoffeeListViewModel
    {
        public IEnumerable<Coffe> allCoffes { get; set; }
        public string currCategory { get; set; }
    }
}