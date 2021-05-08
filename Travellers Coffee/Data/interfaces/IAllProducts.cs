using System.Collections.Generic;
using Travellers_Coffee.Data.Models;

namespace Travellers_Coffee.Data.interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Coffe> Coffes { get; }
        IEnumerable<Coffe> getFavCoffe { get;  }
        Coffe getObjectCoffe(int coffeId);
    }
}