using System;
using DesignPatterns.Adapter;
using DesignPatterns.Adapter.Target;
using DesignPatterns.Decorator;
using DesignPatterns.Decorator.Beverages;
using DesignPatterns.Decorator.Decorators;
using DesignPatterns.Strategy;
using static DesignPatterns.Observer.WithSubscriber.ObservableFactory;
using static DesignPatterns.Observer.WithSubscriber.SampleTransformations;

namespace DesignPatterns {
  public static class Program {
    public static void Main() {
      ObserverPattern();
      DecoratorPattern();
      StrategyPattern();
      AdapterPattern();
      FinishApp();
    }

    private static void AdapterPattern() {
      var adapter = new TargetAdapter(new Target());
      adapter.Publish2();
    }

    private static void StrategyPattern() {
      var duck1 = Duck.NormalDuckFactory();
      var duck2 = Duck.RubberDuckFactory();

      duck1.Fly();
      duck2.Fly();
    }

    private static void DecoratorPattern() {
      AbstractBeverage tea = new Tea();
      AbstractBeverage teaWithChocolate = new ChocolateBeverageAddonDecorator(new Tea());
      Console.Out.WriteLine($"Tea: {tea}, tea with chocolate {teaWithChocolate}");
    }

    private static void ObserverPattern() {
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

      observable.Notify("New test notification");
    }

    private static void FinishApp() {
      Console.Out.WriteLine("Stop...");
      Console.ReadKey();
    }
  }
}
