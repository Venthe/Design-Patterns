namespace DesignPatterns.Pattern.DecoratorPattern.Decorators {
  public class ChocolateBeverageAddonDecorator : AbstractBeverageAddonDecorator {
    public ChocolateBeverageAddonDecorator(AbstractBeverage beverage)
      : base(beverage) {
    }

    public override int GetPrice() => Beverage.GetPrice() + 1;
  }
}
