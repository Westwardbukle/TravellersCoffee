using System.Collections.Generic;
using Travellers_Coffee.Data.Models;

namespace Travellers_Coffee.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Coffe> FavCoffees { get; set; }
    }
}