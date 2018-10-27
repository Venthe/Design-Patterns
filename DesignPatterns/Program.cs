using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.AdapterPattern;
using DesignPatterns.CommandPattern;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.FacadePattern;
using DesignPatterns.FactoryMethodPattern;
using DesignPatterns.ObserverPattern.WithSubscriber;
using DesignPatterns.SingletonPattern;
using DesignPatterns.StrategyPattern;

namespace DesignPatterns {
  public static class Program {
    private static ConsoleUtilities consoleUtilities = new ConsoleUtilities();

    public static void Main() {
      // Order kept as in Christopher Okhravi series
      consoleUtilities.DisplayInBlock(new StrategyPatternSample());
      consoleUtilities.DisplayInBlock(new ObserverPatternWithSubscriberSample());
      consoleUtilities.DisplayInBlock(new DecoratorPatternSample());
      consoleUtilities.DisplayInBlock(new FactoryMethodPatternSample());
      consoleUtilities.DisplayInBlock(new AbstractFactoryPatternSample());
      consoleUtilities.DisplayInBlock(new SingletonPatternSample());
      consoleUtilities.DisplayInBlock(new CommandPatternSample());
      consoleUtilities.DisplayInBlock(new AdapterPatternSample());
      consoleUtilities.DisplayInBlock(new FacadePatternSample());

      consoleUtilities.PauseApp();
    }
  }
}
