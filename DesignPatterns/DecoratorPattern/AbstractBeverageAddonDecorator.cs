namespace DesignPatterns.DecoratorPattern {
  // Possible use case: Deprecating some class by intercepting behaviour
  // Or GetLine wraps around BufferStream wraps around IO
  public abstract class AbstractBeverageAddonDecorator : AbstractBeverage {
    protected AbstractBeverageAddonDecorator(AbstractBeverage beverage) {
      Beverage = beverage;
    }

    protected AbstractBeverage Beverage { get; set; }
  }
}
