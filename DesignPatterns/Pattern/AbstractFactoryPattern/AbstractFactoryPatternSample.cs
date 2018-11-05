using System;
using DesignPatterns.Pattern.AbstractFactoryPattern.ProductFamily1;

namespace DesignPatterns.Pattern.AbstractFactoryPattern {
  public class AbstractFactoryPatternSample : IDesignPatternSample {
    public void ShowSample() {
      IAbstractFactory factory = new ConcreteFactory();

      var product1 = factory.CreateProductA();
      var product2 = factory.CreateProductB();

      Console.Out.WriteLine($"{nameof(IAbstractFactory)} {nameof(ConcreteFactory)} creates {nameof(IProductA)} {factory.CreateProductA().GetType().Name}");
      Console.Out.WriteLine($"{nameof(IAbstractFactory)} {nameof(ConcreteFactory)} creates {nameof(IProductB)} {factory.CreateProductB().GetType().Name}");
    }
  }
}
