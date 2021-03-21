using BusinessRuleEngine.Models;
using System;

namespace BusinessRuleEngine.Services
{
    public class PaymentService: IPaymentService
    {
        /// <summary>
        /// Generate packing Slip 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        public void DoPayment<T>(T item)
        {
            if (item.GetType().Name == typeof(Product).Name)
            {
                Console.WriteLine("Generate a packing slip for shipping");
                Console.WriteLine("Generate a commission payment to the agent.");
            }

            if (item.GetType().Name == typeof(Book).Name)
            {
                Console.WriteLine("Create a duplicate packing slips for the royalty department.");
                Console.WriteLine("Generate a commission payment to the agent.");
            }
            if (item.GetType().Name == typeof(Membership).Name)
            {
                var membership = item as Membership;

                if (membership.MembershipType == MembershipType.New)
                {
                    Console.WriteLine("activate that membership.");
                }
                if (membership.MembershipType == MembershipType.Upgrade)
                {
                    Console.WriteLine("Membership upgraded.");
                }

                Console.WriteLine("e-mail the owner and inform them of the activation / upgrade.");
            }
            if (item.GetType().Name == typeof(Video).Name)
            {
                var video = item as Video;
                if (video.Name == "Learning to Ski")
                {
                    Console.WriteLine("add free \"First Aid\" video to the packing slip (the result of a court decision in 1997)");
                }
            }
        }
    }
}
