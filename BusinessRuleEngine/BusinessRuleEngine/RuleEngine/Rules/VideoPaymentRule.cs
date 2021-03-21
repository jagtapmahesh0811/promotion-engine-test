using BusinessRuleEngine.Models;
using System;

namespace BusinessRuleEngine.RuleEngine.Rules
{
    public class VideoPaymentRule : IPaymentRule
    {
        public void DoPaymentWithRuleEngine<T>(T item)
        {
            if (item.GetType().Name == typeof(Video).Name)
            {
                var video = item as Video;
                if (video.Name == "Learning to Ski")
                {
                    // ToDo: add free \"First Aid\" video to the packing slip and generate it.
                    Console.WriteLine("add free \"First Aid\" video to the packing slip (the result of a court decision in 1997)");
                }
            }
        }
    }
}
