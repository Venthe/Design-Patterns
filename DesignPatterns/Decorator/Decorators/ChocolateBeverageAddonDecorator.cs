namespace DesignPatterns.Decorator.Decorators
{
   class ChocolateBeverageAddonDecorator : AbstractBeverageAddonDecorator
   {
      public ChocolateBeverageAddonDecorator(AbstractBeverage beverage) : base(beverage)
      {
      }

      public override int GetPrice() => this.beverage.GetPrice() + 1;
   }
}
