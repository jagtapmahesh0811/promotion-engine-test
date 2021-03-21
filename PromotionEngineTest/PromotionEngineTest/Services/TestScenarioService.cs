using PromotionEngineTest.Enums;
using PromotionEngineTest.Interfaces;
using PromotionEngineTest.Models;
using System;
using System.Collections.Generic;

namespace PromotionEngineTest.Services
{
    public class TestScenarioService: ITestScenarioService
    {
        private IPromotionService _promotionService;
        private ICartService _cartService;

        public TestScenarioService(IPromotionService promoService, ICartService cartService)
        {
            this._promotionService = promoService;
            this._cartService = cartService;
        }

        // 3 of A for 130
        // 2 of Bfor 45
        // C & D for 30
        public void InitializeTestPromotions()
        {
            // Initialize Offers
            var offer_SkuA = new Dictionary<SKUEnum, int>();
            offer_SkuA.Add(SKUEnum.A, 3);

            var offer_SkuB = new Dictionary<SKUEnum, int>();
            offer_SkuB.Add(SKUEnum.B, 2);

            var offer_SkuCnD = new Dictionary<SKUEnum, int>();
            offer_SkuCnD.Add(SKUEnum.C, 1);
            offer_SkuCnD.Add(SKUEnum.D, 1);


            // Add Promotions
            this._promotionService.AddPromotions(new Promotion(1, offer_SkuA, 130));
            this._promotionService.AddPromotions(new Promotion(2, offer_SkuB, 45));
            this._promotionService.AddPromotions(new Promotion(3, offer_SkuCnD, 30));
        }

        // 1 * A = 50
        // 1 * B = 30
        // 1 * C = 20
        // -----------
        // Total = 100
        public void ExecuteFirstScenario()
        {
            this._cartService.CreateNewOrder(1);

            this._cartService.AddItemsToCart(new Product(SKUEnum.A), 1);
            this._cartService.AddItemsToCart(new Product(SKUEnum.B), 1);
            this._cartService.AddItemsToCart(new Product(SKUEnum.C), 1);

            var totalPrice = this._cartService.GetTotalPrice();
            var totalPromtionalPrice = this._cartService.GetTotalPriceWithPromotion();

            Console.WriteLine("For First Scenario - Total Price : {0}, PromotionalPrice : {1}", totalPrice, totalPromtionalPrice);
        }

        // 5* A 130 + 2*50
        // 5 * B 45+45+30
        // 1 * C 20
        // -----------
        // Total = 370
        public void ExecuteSecondScenario()
        {
            this._cartService.CreateNewOrder(1);

            this._cartService.AddItemsToCart(new Product(SKUEnum.A), 5);
            this._cartService.AddItemsToCart(new Product(SKUEnum.B), 5);
            this._cartService.AddItemsToCart(new Product(SKUEnum.C), 1);

            var totalPrice = this._cartService.GetTotalPrice();
            var totalPromtionalPrice = this._cartService.GetTotalPriceWithPromotion();

            Console.WriteLine("For Second Scenario - Total Price : {0}, PromotionalPrice : {1}", totalPrice, totalPromtionalPrice);
        }

        // 3 * A 130
        // 15* B 45+45+1*30 (This is incorrect as per mentioned in Assessment Document. It should be "7*45 + 1*30"
        // 1 * C -
        // 1 * D 30
        // -----------
        // Total = 280 (Correct Total Should be 505)
        public void ExecuteThirdScenario()
        {
            this._cartService.CreateNewOrder(1);

            this._cartService.AddItemsToCart(new Product(SKUEnum.A), 3);
            this._cartService.AddItemsToCart(new Product(SKUEnum.B), 15);
            this._cartService.AddItemsToCart(new Product(SKUEnum.C), 1);
            this._cartService.AddItemsToCart(new Product(SKUEnum.D), 1);

            var totalPrice = this._cartService.GetTotalPrice();
            var totalPromtionalPrice = this._cartService.GetTotalPriceWithPromotion();

            Console.WriteLine("For Third Scenario - Total Price : {0}, PromotionalPrice : {1}", totalPrice, totalPromtionalPrice);
        }

    }
}
