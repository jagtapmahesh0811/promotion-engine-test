using PromotionEngineTest.Enums;
using System.Collections.Generic;

namespace PromotionEngineTest.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public Dictionary<SKUEnum, int> PromotionOffer { get; set; }
        public decimal Price { get; set; }

        public Promotion(int id, Dictionary<SKUEnum, int> offers, decimal price)
        {
            Id = id;
            PromotionOffer = offers;
            Price = price;
        }
    }
}
