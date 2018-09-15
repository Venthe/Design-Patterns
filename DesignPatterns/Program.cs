using DesignPatterns.Decorator;
using DesignPatterns.Decorator.Beverages;
using DesignPatterns.Decorator.Decorators;
using System;
using static DesignPatterns.Observer.WithSubscriber.ObservableFactory;
using static DesignPatterns.Observer.WithSubscriber.SampleTransformations;

namespace DesignPatterns
{
   public static class Program
   {
      public static void Main()
      {
         Console.WriteLine("Hello World!");
         ObserverPattern();
         DecoratorPattern();
         FinishApp();
      }

      private static void DecoratorPattern()
      {
         AbstractBeverage tea = new Tea();
         AbstractBeverage teaWithChocolate = new ChocolateBeverageAddonDecorator(new Tea());
         Console.Out.WriteLine($"Tea: {tea}, tea with chocolate {teaWithChocolate}");
      }

      private static void ObserverPattern()
      {
         var observable = Of<string>();

         var observer1 = observable.Subscribe().Pipe(
            ToUpper,
            Tap(Log())
            );

         var observer2 = observable.Subscribe().Pipe(
            Map(v => v.ToString() + " New text"),
            Tap(Log())
            );

         observable.Subscribe();

         observable.Notify("New text notification");
      }

      private static void FinishApp()
      {
         Console.Out.WriteLine("Stop...");
         Console.ReadKey();
      }
   }
}
