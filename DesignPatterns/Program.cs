using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.AdapterPattern;
using DesignPatterns.BridgePattern;
using DesignPatterns.CommandPattern;
using DesignPatterns.CompositePattern;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.FacadePattern;
using DesignPatterns.FactoryMethodPattern;
using DesignPatterns.ObserverPattern.WithSubscriber;
using DesignPatterns.ProxyPattern;
using DesignPatterns.SingletonPattern;
using DesignPatterns.StrategyPattern;
using DesignPatterns.TemplateMethodPattern;

namespace DesignPatterns {
  public static class Program {
    private static readonly ConsoleUtilities consoleUtilities = new ConsoleUtilities();

    public static void Main() {
      // Order kept as in Christopher Okhravi series
      // TODO: Provide readme file with observations & usage strategies and notes how I understand the patterns
      // TODO: Confront understanding with GoF book
      // TODO: Consider UML diagrams
      consoleUtilities.DisplayInBlock(new StrategyPatternSample());
      consoleUtilities.DisplayInBlock(new ObserverPatternWithSubscriberSample());
      consoleUtilities.DisplayInBlock(new DecoratorPatternSample());
      consoleUtilities.DisplayInBlock(new FactoryMethodPatternSample());
      consoleUtilities.DisplayInBlock(new AbstractFactoryPatternSample());
      consoleUtilities.DisplayInBlock(new SingletonPatternSample());
      consoleUtilities.DisplayInBlock(new CommandPatternSample());
      consoleUtilities.DisplayInBlock(new AdapterPatternSample());
      consoleUtilities.DisplayInBlock(new FacadePatternSample());
      consoleUtilities.DisplayInBlock(new ProxyPatternSample());
      consoleUtilities.DisplayInBlock(new BridgePatternSample());
      consoleUtilities.DisplayInBlock(new TemplateMethodPatternSample());
      consoleUtilities.DisplayInBlock(new CompositePatternSample());
      // TODO: Iterator pattern
      // TODO: State pattern
      // TODO: Null Object pattern

      consoleUtilities.PauseApp();
    }
  }
}
