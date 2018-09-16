namespace DesignPatterns.Decorator {
  // Possible use case: Deprecating some class by intercepting behaviour
  // Or GetLine wraps around BufferStream wraps around IO
  public abstract class AbstractBeverageAddonDecorator : AbstractBeverage {
    protected AbstractBeverage beverage;
    protected AbstractBeverageAddonDecorator(AbstractBeverage beverage) => this.beverage = beverage;
  }
}
