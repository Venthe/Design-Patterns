namespace DesignPatterns.AbstractFactory.ProductFamily1 {
  class ConcreteFactory : IAbstractFactory {
    public IProductA CreateProductA() => new ProductA();
    public IProductB CreateProductB() => new ProductB();
  }
}
