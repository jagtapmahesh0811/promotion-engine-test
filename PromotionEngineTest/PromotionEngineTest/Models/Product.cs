using PromotionEngineTest.Enums;
using System;

namespace PromotionEngineTest.Models
{
    public class Product
    {
        public SKUEnum SKU;
        public decimal Price;

        public Product(SKUEnum sKU)
        {
            SKU = sKU;

            switch (sKU)
            {
                case SKUEnum.A: Price = 50;
                    break;
                case SKUEnum.B: Price = 30;
                    break;
                case SKUEnum.C: Price = 20;
                    break;
                case SKUEnum.D: Price = 15;
                    break;
                default:
                    Console.WriteLine("Product SKU not found");
                    break;
            }
        }
    }
}
