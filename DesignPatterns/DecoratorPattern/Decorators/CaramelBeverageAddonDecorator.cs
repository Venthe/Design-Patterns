﻿namespace DesignPatterns.DecoratorPattern.Decorators {
  public class CaramelBeverageAddonDecorator : AbstractBeverageAddonDecorator {
    public CaramelBeverageAddonDecorator(AbstractBeverage beverage) : base(beverage) {
    }

    public override int GetPrice() => beverage.GetPrice() + 4;
  }
}
