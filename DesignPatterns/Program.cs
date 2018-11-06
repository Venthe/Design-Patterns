using DesignPatterns.Pattern.AbstractFactoryPattern;
using DesignPatterns.Pattern.AdapterPattern;
using DesignPatterns.Pattern.BridgePattern;
using DesignPatterns.Pattern.CommandPattern;
using DesignPatterns.Pattern.CompositePattern;
using DesignPatterns.Pattern.DecoratorPattern;
using DesignPatterns.Pattern.FacadePattern;
using DesignPatterns.Pattern.FactoryMethodPattern;
using DesignPatterns.Pattern.IteratorPattern;
using DesignPatterns.Pattern.NullObjectpattern;
using DesignPatterns.Pattern.ObserverPattern.WithSubscriber;
using DesignPatterns.Pattern.ProxyPattern;
using DesignPatterns.Pattern.SingletonPattern;
using DesignPatterns.Pattern.StrategyPattern;
using DesignPatterns.Pattern.TemplateMethodPattern;
using DesignPatterns.Utilities;

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
      ConsoleUtilities.DisplayInBlock(new IteratorPatternSample());
      ConsoleUtilities.DisplayInBlock(new StatePatternSample());
      // TODO: Chain of responsibility pattern
      // TODO: Interpreter pattern
      // TODO: Mediator pattern
      // TODO: Memento pattern
      // TODO: Visitor pattern
    }

    private static void OtherPatterns() {
      ConsoleUtilities.DisplayInBlock(new NullObjectPatternSample());
    }
  }
}
