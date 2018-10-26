using DesignPatterns.AbstractFactoryPattern.ProductFamily1;

namespace DesignPatterns.AbstractFactoryPattern {
  public class AbstractFactoryPatternSample : IDesignPatternSample {
    public void ShowSample() {
      IAbstractFactory factory = new ConcreteFactory();

      var product1 = factory.CreateProductA();
      var product2 = factory.CreateProductB();
    }
  }
}
