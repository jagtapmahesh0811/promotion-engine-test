using System.Collections.Generic;
using System.Linq;

namespace BusinessRuleEngine.RuleEngine
{
    public class PaymentRuleEngine
    {
        List<IPaymentRule> paymentRules = new List<IPaymentRule>();

        public PaymentRuleEngine(IEnumerable<IPaymentRule> rules)
        {
            paymentRules = rules.ToList();
        }

        public void DoPayment<T>(T item)
        {
            foreach (var rule in paymentRules)
            {
                rule.DoPaymentWithRuleEngine(item);
            }
        }
    }
}
