namespace Travellers_Coffee.Data.Models
{
    public class Coffe
    {
        public int id { set; get; }
        
        public string name { set; get; }
        
        public string shortDesc { set; get; }
        
        public string longDesc { set; get; }
        
        public string img { set; get; }
        
        public ushort price { set; get; }
        
        public bool isFavorite { set; get; }
        
        public bool avaiable { set; get; }
        
        public int categoryID { set; get; }
        
        public virtual Category Category { set; get; }
    }
}