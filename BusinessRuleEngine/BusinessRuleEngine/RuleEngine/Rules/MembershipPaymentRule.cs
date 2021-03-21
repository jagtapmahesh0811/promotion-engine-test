using BusinessRuleEngine.Models;
using System;

namespace BusinessRuleEngine.RuleEngine.Rules
{
    public class MembershipPaymentRule : IPaymentRule
    {
        public void DoPaymentWithRuleEngine<T>(T item)
        {
            if (item.GetType().Name == typeof(Membership).Name)
            {
                var membership = item as Membership;

                if (membership.MembershipType == MembershipType.New)
                {
                    // ToDo: activate that membership.
                    Console.WriteLine("activate that membership.");
                }
                if (membership.MembershipType == MembershipType.Upgrade)
                {
                    // ToDo: Upgrade the membership
                    Console.WriteLine("Membership upgraded.");
                }

                // ToDo: Email to owner
                Console.WriteLine("e-mail the owner and inform them of the activation / upgrade.");
            }
        }
    }
}
