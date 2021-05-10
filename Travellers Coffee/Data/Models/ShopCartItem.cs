namespace Travellers_Coffee.Data.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Coffe coffe { get; set; }
        public int price { get; set; }
        
        public string ShopCartId { get; set;  }
    }
}