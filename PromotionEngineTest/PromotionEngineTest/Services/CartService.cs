using PromotionEngineTest.Interfaces;
using PromotionEngineTest.Models;
using System.Linq;

namespace PromotionEngineTest.Services
{
    public class CartService: ICartService
    {
        private Order currentOrder;
        private IPromotionService _promotionService;

        public CartService(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }

        public void CreateNewOrder(int orderId)
        {
            currentOrder = new Order(orderId);
        }

        public void AddItemsToCart(Product prod, int qty)
        {
            while(qty > 0)
            {
                currentOrder.Products.Add(prod);
                qty--;
            }
        }

        // Get Total price by per item
        public decimal GetTotalPrice()
        {
            return this.currentOrder.Products.Sum(o => o.Price);
        }

        // Get Total Price with applicable Promotions
        public decimal GetTotalPriceWithPromotion()
        {
            decimal totalPrice = 0;

            foreach (var promo in this._promotionService.GetPromotions())
            {
                totalPrice += PromotionCalculatorService.GetTotalPriceWithPromotion(this.currentOrder, promo);
            }

            return totalPrice;
        }
    }
}
