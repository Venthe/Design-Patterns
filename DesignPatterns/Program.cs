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

#pragma warning disable SA1515
#pragma warning disable SA1512
namespace DesignPatterns {
  public static class Program {
    private static readonly ConsoleUtilities ConsoleUtilities = new ConsoleUtilities();

    // TODO: Provide readme file with observations & usage strategies and notes how I understand the patterns
    // TODO: Confront understanding with "Design Patterns: Elements of Reusable Object-Oriented Software" book
    // TODO: Consider UML diagrams
    public static void Main() {
      CreationalPatterns();
      StructuralPattterns();
      BehavioralPatterns();
      OtherPatterns();
      // TODO: Consider Concurrency patterns
      // TODO: Consider Architectural patterns

      ConsoleUtilities.PauseApp();
    }

    private static void CreationalPatterns() {
      ConsoleUtilities.DisplayInBlock(new AbstractFactoryPatternSample());
      ConsoleUtilities.DisplayInBlock(new FactoryMethodPatternSample());
      ConsoleUtilities.DisplayInBlock(new SingletonPatternSample());
      // TODO: Builder pattern
      // TODO: Prototype pattern
    }

    private static void StructuralPattterns() {
      ConsoleUtilities.DisplayInBlock(new AdapterPatternSample());
      ConsoleUtilities.DisplayInBlock(new BridgePatternSample());
      ConsoleUtilities.DisplayInBlock(new CompositePatternSample());
      ConsoleUtilities.DisplayInBlock(new DecoratorPatternSample());
      ConsoleUtilities.DisplayInBlock(new FacadePatternSample());
      ConsoleUtilities.DisplayInBlock(new ProxyPatternSample());
      // TODO: Flyweight pattern
    }

    private static void BehavioralPatterns() {
      ConsoleUtilities.DisplayInBlock(new StrategyPatternSample());
      ConsoleUtilities.DisplayInBlock(new ObserverPatternWithSubscriberSample());
      ConsoleUtilities.DisplayInBlock(new CommandPatternSample());
      ConsoleUtilities.DisplayInBlock(new TemplateMethodPatternSample());
      // TODO: Chain of responsibility pattern
      // TODO: Interpreter pattern
      // TODO: Iterator pattern
      // TODO: Mediator pattern
      // TODO: Memento pattern
      // TODO: State pattern
      // TODO: Visitor pattern
    }

    private static void OtherPatterns() {
      // TODO: Null Object pattern
    }
  }
}
