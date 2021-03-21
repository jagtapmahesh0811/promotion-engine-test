using PromotionEngineTest.Interfaces;
using PromotionEngineTest.Models;
using System.Collections.Generic;

namespace PromotionEngineTest.Services
{
    public class PromotionService: IPromotionService
    {
        private static List<Promotion> _promotions;

        static PromotionService()
        {
            _promotions = new List<Promotion>();
        }

        public IEnumerable<Promotion> GetPromotions()
        {
            return _promotions;
        }

        public void AddPromotions(Promotion promo)
        {
            _promotions.Add(promo);
        }
    }
}
