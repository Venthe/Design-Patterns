namespace DesignPatterns.Decorator.Decorators {
  class CaramelBeverageAddonDecorator : AbstractBeverageAddonDecorator {
    public CaramelBeverageAddonDecorator(AbstractBeverage beverage) : base(beverage) {
    }

    public override int GetPrice() => this.beverage.GetPrice() + 4;
  }
}
