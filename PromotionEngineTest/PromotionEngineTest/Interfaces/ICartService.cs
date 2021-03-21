using PromotionEngineTest.Models;

namespace PromotionEngineTest.Interfaces
{
    public interface ICartService
    {
        void CreateNewOrder(int orderId);
        void AddItemsToCart(Product prod, int qty);
        decimal GetTotalPrice();
        decimal GetTotalPriceWithPromotion();
    }
}
