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
    private static readonly ConsoleUtilities ConsoleUtilities = new ConsoleUtilities();

    public static void Main() {
      // Order kept as in Christopher Okhravi series
      // TODO: Provide readme file with observations & usage strategies and notes how I understand the patterns
      // TODO: Confront understanding with GoF book
      // TODO: Consider UML diagrams
      ConsoleUtilities.DisplayInBlock(new StrategyPatternSample());
      ConsoleUtilities.DisplayInBlock(new ObserverPatternWithSubscriberSample());
      ConsoleUtilities.DisplayInBlock(new DecoratorPatternSample());
      ConsoleUtilities.DisplayInBlock(new FactoryMethodPatternSample());
      ConsoleUtilities.DisplayInBlock(new AbstractFactoryPatternSample());
      ConsoleUtilities.DisplayInBlock(new SingletonPatternSample());
      ConsoleUtilities.DisplayInBlock(new CommandPatternSample());
      ConsoleUtilities.DisplayInBlock(new AdapterPatternSample());
      ConsoleUtilities.DisplayInBlock(new FacadePatternSample());
      ConsoleUtilities.DisplayInBlock(new ProxyPatternSample());
      ConsoleUtilities.DisplayInBlock(new BridgePatternSample());
      ConsoleUtilities.DisplayInBlock(new TemplateMethodPatternSample());
      ConsoleUtilities.DisplayInBlock(new CompositePatternSample());

      // TODO: Iterator pattern
      // TODO: State pattern
      // TODO: Null Object pattern
      ConsoleUtilities.PauseApp();
    }
  }
}
