using System.Collections.Generic;
using Travellers_Coffee.Data.Models;

namespace Travellers_Coffee.Data.interfaces
{
    public interface ICoffeCategory
    {
        IEnumerable<Category> allCategories { get; }
    }
}