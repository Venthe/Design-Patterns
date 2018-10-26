namespace DesignPatterns.DecoratorPattern.Decorators {
  public class ChocolateBeverageAddonDecorator : AbstractBeverageAddonDecorator {
    public ChocolateBeverageAddonDecorator(AbstractBeverage beverage) : base(beverage) {
    }

    public override int GetPrice() => beverage.GetPrice() + 1;
  }
}
