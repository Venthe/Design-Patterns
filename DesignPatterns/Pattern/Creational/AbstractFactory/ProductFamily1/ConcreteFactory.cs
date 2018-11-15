namespace DesignPatterns.Pattern.Creational.AbstractFactory.ProductFamily1 {
  public class ConcreteFactory : IAbstractFactory {
    public IProductA CreateProductA() => new ProductA();

    public IProductB CreateProductB() => new ProductB();
  }
}
