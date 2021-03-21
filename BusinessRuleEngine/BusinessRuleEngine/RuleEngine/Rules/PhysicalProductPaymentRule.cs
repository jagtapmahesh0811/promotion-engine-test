using BusinessRuleEngine.Models;
using System;

namespace BusinessRuleEngine.RuleEngine
{
    public class PhysicalProductPaymentRule: IPaymentRule
    {
        public void DoPaymentWithRuleEngine<T>(T item)
        {
            if (item.GetType().Name == typeof(Product).Name)
            {

                // ToDo: Generate a packing slip for shipping
                Console.WriteLine("Generate a packing slip for shipping");

                // ToDo: Generate a commission payment to the agent.
                Console.WriteLine("Generate a commission payment to the agent.");
            }
        }
    }
}
