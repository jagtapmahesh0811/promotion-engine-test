using BusinessRuleEngine.Models;
using BusinessRuleEngine.Services;
using System;

namespace BusinessRuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note - Currently the rule engine is implemented and rest things/actions are logged in console.
            // If require we can implement relevant functionality in the respective ToDo's

            IPaymentService paymentForPhysicalProduct = new PaymentService();
            Console.WriteLine("For Physical Product");
            paymentForPhysicalProduct.DoPayment(new Product(1, "Physical Product Name"));
            Console.WriteLine();

            IPaymentService paymentForBook = new PaymentService();
            Console.WriteLine("For Book");
            paymentForBook.DoPayment(new Book(1, "Book Name"));
            Console.WriteLine();

            IPaymentService paymentForNewMembership = new PaymentService();
            Console.WriteLine("For New Membership");
            paymentForNewMembership.DoPayment(new Membership(1, MembershipType.New));
            Console.WriteLine();

            IPaymentService paymentForUpgradeMembership = new PaymentService();
            Console.WriteLine("For Upgrade Membership");
            paymentForUpgradeMembership.DoPayment(new Membership(1, MembershipType.Upgrade));
            Console.WriteLine();

            IPaymentService paymentForVideo = new PaymentService();
            Console.WriteLine("For Learning to Ski video");
            paymentForVideo.DoPayment(new Video(1, "Learning to Ski"));
            Console.WriteLine();

            Console.Read();
        }
    }
}
