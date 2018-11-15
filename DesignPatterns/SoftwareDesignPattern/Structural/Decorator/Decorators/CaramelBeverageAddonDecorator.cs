namespace DesignPatterns.SoftwareDesignPattern.Structural.Decorator.Decorators {
  public class CaramelBeverageAddonDecorator : AbstractBeverageAddonDecorator {
    public CaramelBeverageAddonDecorator(AbstractBeverage beverage)
      : base(beverage) {
    }

    public override int GetPrice() => Beverage.GetPrice() + 4;
  }
}
