using DesignPatterns.Pattern.Behavioral.Command;
using DesignPatterns.Pattern.Behavioral.Iterator;
using DesignPatterns.Pattern.Behavioral.Observer.WithSubscriber;
using DesignPatterns.Pattern.Behavioral.State;
using DesignPatterns.Pattern.Behavioral.Strategy;
using DesignPatterns.Pattern.Behavioral.TemplateMethod;
using DesignPatterns.Pattern.Behavioral.Visitor;
using DesignPatterns.Pattern.Creational.AbstractFactory;
using DesignPatterns.Pattern.Creational.Builder;
using DesignPatterns.Pattern.Creational.FactoryMethod;
using DesignPatterns.Pattern.Creational.Singleton;
using DesignPatterns.Pattern.Other.NullObject;
using DesignPatterns.Pattern.Structural.Adapter;
using DesignPatterns.Pattern.Structural.Bridge;
using DesignPatterns.Pattern.Structural.Composite;
using DesignPatterns.Pattern.Structural.Decorator;
using DesignPatterns.Pattern.Structural.Facade;
using DesignPatterns.Pattern.Structural.Proxy;
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
      ConsoleUtilities.DisplayInBlock(new BuilderPatternSample());
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
      ConsoleUtilities.DisplayInBlock(new VisitorPatternSample());
      // TODO: Chain of responsibility pattern
      // TODO: Interpreter pattern
      // TODO: Mediator pattern
      // TODO: Memento pattern
    }

    private static void OtherPatterns() {
      ConsoleUtilities.DisplayInBlock(new NullObjectPatternSample());
    }
  }
}
