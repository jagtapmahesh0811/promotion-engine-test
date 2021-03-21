using PromotionEngineTest.Models;
using System;
using System.Linq;

namespace PromotionEngineTest.Services
{
    public static class PromotionCalculatorService
    {
        public static decimal GetTotalPriceWithPromotion(Order order, Promotion promotion)
        {
            decimal totalPrice = 0;
            var promoOffers = promotion.PromotionOffer;
            // Get the relevant products applicable for promotion
            var products = order.Products.Where(x => promotion.PromotionOffer.Keys.Contains(x.SKU));

            if (products.Any())
            {
                int? prodCountForPromotion = null;

                #region Calculate Promotional Itmes Price
                foreach (var offer in promoOffers)
                {
                    var maxProductsOfOffer = products.Where(x => x.SKU == offer.Key);
                    // Get max count applicable for combined promotion 
                    int applicableItemsForOffer = maxProductsOfOffer.Count() / offer.Value;
                    prodCountForPromotion = prodCountForPromotion == null || applicableItemsForOffer < prodCountForPromotion ?
                    applicableItemsForOffer : prodCountForPromotion;
                }

                // calculate the total price of products applicable for promotions
                totalPrice += prodCountForPromotion != null ? promotion.Price * prodCountForPromotion.Value : 0;
                #endregion

                #region Calculate Non Promotional Itmes Price
                foreach (var offer in promoOffers)
                {
                    var maxProductsOfOffer = products.Where(x => x.SKU == offer.Key);

                    if (maxProductsOfOffer.Any())
                    {
                        var prodCountWithoutPromotion = prodCountForPromotion != null && prodCountForPromotion != 0 ?
                            maxProductsOfOffer.Count() - offer.Value * prodCountForPromotion.Value :
                            maxProductsOfOffer.Count();
                        
                        var firstItem = products.FirstOrDefault(x => x.SKU.Equals(offer.Key));

                        if (firstItem != null)
                        {
                            totalPrice += prodCountWithoutPromotion * firstItem.Price;
                        }
                    }
                }
                #endregion
            }

            return totalPrice;
        }
    }
}
