using BusinessRuleEngine.Models;
using System;

namespace BusinessRuleEngine.RuleEngine.Rules
{
    public class BookPaymentRule: IPaymentRule
    {
        public void DoPaymentWithRuleEngine<T>(T item)
        {
            if (item.GetType().Name == typeof(Book).Name)
            {
                // ToDo: Create duplicate packing slips
                Console.WriteLine("Create a duplicate packing slips for the royalty department.");
                // ToDo: Generate commission payment to agent
                Console.WriteLine("Generate a commission payment to the agent.");
            }
        }
    }
}
