using System;
using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.AbstractFactoryPattern.ProductFamily1;
using DesignPatterns.AdapterPattern;
using DesignPatterns.AdapterPattern.Target;
using DesignPatterns.CommandPattern;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.DecoratorPattern.Beverages;
using DesignPatterns.DecoratorPattern.Decorators;
using DesignPatterns.FacadePattern;
using DesignPatterns.FactoryMethodPattern.Factory;
using DesignPatterns.ObserverPattern.WithSubscriber;
using DesignPatterns.SingletonPattern;
using DesignPatterns.StrategyPattern;
using DesignPatterns.StrategyPattern.FlyStrategy;

namespace DesignPatterns {
  public static class Program {
    private static ConsoleUtilities consoleUtilities;

    public static void Main() {
      consoleUtilities = new ConsoleUtilities();

      // Order kept as in Christopher Okhravi series
      consoleUtilities.InvokeInConsoleBlock(StrategyPatternSample);
      consoleUtilities.InvokeInConsoleBlock(ObserverPatternSample);
      consoleUtilities.InvokeInConsoleBlock(DecoratorPatternSample);
      consoleUtilities.InvokeInConsoleBlock(FactoryMethodPatternSample);
      consoleUtilities.InvokeInConsoleBlock(AbstractFactoryPatternSample);
      consoleUtilities.InvokeInConsoleBlock(SingletonPatternSample);
      consoleUtilities.InvokeInConsoleBlock(CommandPatternSample);
      consoleUtilities.InvokeInConsoleBlock(AdapterPatternSample);
      consoleUtilities.InvokeInConsoleBlock(FacadePatternSample);

      consoleUtilities.PauseApp();
    }

    private static void StrategyPatternSample() {
      var duck1 = new Duck(new NoFlightStrategy());
      var duck2 = new Duck(new NormalFlightStrategy());

      duck1.Fly();
      duck2.Fly();
    }

    private static void ObserverPatternSample() {
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

    private static void DecoratorPatternSample() {
      AbstractBeverage tea = new Tea();
      AbstractBeverage teaWithChocolate = new ChocolateBeverageAddonDecorator(new Tea());
      Console.Out.WriteLine($"Tea: {tea}, tea with chocolate {teaWithChocolate}");
    }

    private static void FactoryMethodPatternSample() {
      var objectCreatedByFactoryMethod = new Creator1().FactoryMethod();
      var otherMethodResult = new Creator1().OtherStuff();
    }

    private static void AbstractFactoryPatternSample() {
      IAbstractFactory factory = new ConcreteFactory();

      var product1 = factory.CreateProductA();
      var product2 = factory.CreateProductB();
    }

    private static void SingletonPatternSample() {
      var singleton1 = new Singleton();
      var singleton2 = new Singleton();

      Console.Out.WriteLine($"This should be true: {singleton1.GetInstance().Equals(singleton2.GetInstance())}");
    }

    private static void CommandPatternSample() {
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

    private static void AdapterPatternSample() {
      var adapter = new TargetAdapter(new Target());
      adapter.MyNameForOriginalPublish();
    }

    private static void FacadePatternSample() {
      var facade = new Facade();
      facade.UseMethodBehindFacade("Sample");
    }
  }
}
