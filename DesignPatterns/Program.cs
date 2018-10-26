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
      consoleUtilities.InvokeInConsoleBlock(new StrategyPatternSample().ShowSample);
      consoleUtilities.InvokeInConsoleBlock(new ObserverPatternWithSubscriberSample().ShowSample);
      consoleUtilities.InvokeInConsoleBlock(new DecoratorPatternSample().ShowSample);
      consoleUtilities.InvokeInConsoleBlock(new FactoryMethodPatternSample().ShowSample);
      consoleUtilities.InvokeInConsoleBlock(new AbstractFactoryPatternSample().ShowSample);
      consoleUtilities.InvokeInConsoleBlock(new SingletonPatternSample().ShowSample);
      consoleUtilities.InvokeInConsoleBlock(new CommandPatternSample().ShowSample);
      consoleUtilities.InvokeInConsoleBlock(new AdapterPatternSample().ShowSample);
      consoleUtilities.InvokeInConsoleBlock(new FacadePatternSample().ShowSample);

      consoleUtilities.PauseApp();
    }
  }
}
