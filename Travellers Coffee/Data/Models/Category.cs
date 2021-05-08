using System.Collections.Generic;

namespace Travellers_Coffee.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        
        public string categoryName { set; get; }
        
        public string desc { set; get; }
        
        public List<Coffe> Coffes { set; get; }
    }
}