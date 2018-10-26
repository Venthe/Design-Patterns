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
    private static ConsoleUtilities consoleUtilities;

    public static void Main() {
      consoleUtilities = new ConsoleUtilities();

      // Order kept as in Christopher Okhravi series
      consoleUtilities.InvokeInConsoleBlock(new StrategyPatternSample());
      consoleUtilities.InvokeInConsoleBlock(new ObserverPatternWithSubscriberSample());
      consoleUtilities.InvokeInConsoleBlock(new DecoratorPatternSample());
      consoleUtilities.InvokeInConsoleBlock(new FactoryMethodPatternSample());
      consoleUtilities.InvokeInConsoleBlock(new AbstractFactoryPatternSample());
      consoleUtilities.InvokeInConsoleBlock(new SingletonPatternSample());
      consoleUtilities.InvokeInConsoleBlock(new CommandPatternSample());
      consoleUtilities.InvokeInConsoleBlock(new AdapterPatternSample());
      consoleUtilities.InvokeInConsoleBlock(new FacadePatternSample());

      consoleUtilities.PauseApp();
    }
  }
}
