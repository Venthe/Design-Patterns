using System;
using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.AbstractFactoryPattern.ProductFamily1;
using DesignPatterns.AdapterPattern;
using DesignPatterns.AdapterPattern.Target;
using DesignPatterns.CommandPattern;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.DecoratorPattern.Beverages;
using DesignPatterns.DecoratorPattern.Decorators;
using DesignPatterns.FactoryMethodPattern.Factory;
using DesignPatterns.ObserverPattern.WithSubscriber;
using DesignPatterns.SingletonPattern;
using DesignPatterns.StrategyPattern;
using DesignPatterns.StrategyPattern.FlyStrategy;

namespace DesignPatterns {
  public static class Program {
    public static void Main() {
      // Order kept as in Christopher Okhravi series
      InvokeAsBlock(StrategyPattern);
      InvokeAsBlock(ObserverPattern);
      InvokeAsBlock(DecoratorPattern);
      InvokeAsBlock(FactoryMethodPattern);
      InvokeAsBlock(AbstractFactoryPattern);
      InvokeAsBlock(SingletonPattern);
      InvokeAsBlock(CommandPattern);
      InvokeAsBlock(AdapterPattern);

      FinishApp();
    }

    private static void InvokeAsBlock(Action callback) {
      const int padCount = 78;
      const char padChar = '-';
      
      Console.WriteLine(callback.Method.ToString().PadRight(padCount, padChar));
      callback.Invoke();
      Console.WriteLine(string.Empty.PadRight(padCount, padChar));
      Console.WriteLine();
    }

    private static void StrategyPattern() {
      var duck1 = new Duck(new NoFlightStrategy());
      var duck2 = new Duck(new NormalFlightStrategy());

      duck1.Fly();
      duck2.Fly();
    }

    private static void ObserverPattern() {
      var observable = ObservableFactory.Of<string>();

      var observer1 = observable.Subscribe().Pipe(
         SampleTransformations.ToUpper,
         SampleTransformations.Tap(SampleTransformations.Log())
         );

      var observer2 = observable.Subscribe().Pipe(
         SampleTransformations.Map(v => v.ToString() + " New text"),
         SampleTransformations.Tap(SampleTransformations.Log())
         );

      observable.Subscribe();

      observable.Notify("New test notification");
    }

    private static void DecoratorPattern() {
      AbstractBeverage tea = new Tea();
      AbstractBeverage teaWithChocolate = new ChocolateBeverageAddonDecorator(new Tea());
      Console.Out.WriteLine($"Tea: {tea}, tea with chocolate {teaWithChocolate}");
    }

    private static void FactoryMethodPattern() {
      var objectCreatedByFactoryMethod = new Creator1().FactoryMethod();
      var otherMethodResult = new Creator1().OtherStuff();
    }

    private static void AbstractFactoryPattern() {
      IAbstractFactory factory = new ConcreteFactory();

      var product1 = factory.CreateProductA();
      var product2 = factory.CreateProductB();
    }

    private static void SingletonPattern() {
      var singleton1 = new Singleton();
      var singleton2 = new Singleton();

      Console.Out.WriteLine($"This should be true: {singleton1.GetInstance().Equals(singleton2.GetInstance())}");
    }

    private static void CommandPattern() {
      var batchInvoker = new BatchInvoker();
      batchInvoker.Commands.Add(new LightOffCommand());
      batchInvoker.Commands.Add(new LightOffCommand());
      batchInvoker.Commands.Add(new LightOffCommand());
      batchInvoker.Commands.Add(new LightOnCommand());

      batchInvoker.DoAll();
      batchInvoker.UndoAll();

      var remote = new Remote {
        RemoteKey1 = new LightOffCommand(),
        RemoteKey2 = new LightOnCommand()
      };

      remote.RemoteKey1.Do();
      remote.RemoteKey2.Undo();
    }

    private static void AdapterPattern() {
      var adapter = new TargetAdapter(new Target());
      adapter.MyNameForOriginalPublish();
    }

    private static void FinishApp() {
      Console.Out.WriteLine("Stop...");
      Console.ReadKey();
    }
  }
}
