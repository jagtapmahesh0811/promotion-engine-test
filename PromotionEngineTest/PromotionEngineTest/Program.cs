using Microsoft.Extensions.DependencyInjection;
using PromotionEngineTest.Interfaces;
using PromotionEngineTest.Services;
using System;

namespace PromotionEngineTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddSingleton<ITestScenarioService, TestScenarioService>()
            .AddSingleton<ICartService, CartService>()
            .AddSingleton<IPromotionService, PromotionService>()
            .BuildServiceProvider();

            var testService = serviceProvider.GetService<ITestScenarioService>();
            testService.InitializeTestPromotions();

            testService.ExecuteFirstScenario();
            testService.ExecuteSecondScenario();
            testService.ExecuteThirdScenario();

            Console.Read();
        }
    }
}
