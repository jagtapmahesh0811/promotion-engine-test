using PromotionEngineTest.Models;
using System.Collections.Generic;

namespace PromotionEngineTest.Interfaces
{
    public interface IPromotionService
    {
        IEnumerable<Promotion> GetPromotions();
        void AddPromotions(Promotion promo);
    }
}
