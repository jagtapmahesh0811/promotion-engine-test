using BusinessRuleEngine.RuleEngine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessRuleEngine.Services
{
    public class PaymentService: IPaymentService
    {
        /// <summary>
        /// Call the engine to switch to sepcific rule
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        public void DoPayment<T>(T item)
        {
            // Ref - https://garywoodfine.com/get-c-classes-implementing-interface/

            var ruleType = typeof(IPaymentRule);
            IEnumerable<IPaymentRule> rules = this.GetType().Assembly.GetTypes()
                .Where(x => ruleType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(r => Activator.CreateInstance(r) as IPaymentRule);

            var paymentRuleEngine = new PaymentRuleEngine(rules);

            paymentRuleEngine.DoPayment(item);
        }
    }
}
