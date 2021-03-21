using System.Collections.Generic;

namespace PromotionEngineTest.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }

        public Order(int id)
        {
            Id = id;
            Products = new List<Product>();
        }
    }
}
