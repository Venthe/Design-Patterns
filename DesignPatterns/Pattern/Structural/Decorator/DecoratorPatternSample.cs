using System;
using DesignPatterns.Pattern.Structural.Decorator.Beverages;
using DesignPatterns.Pattern.Structural.Decorator.Decorators;

namespace DesignPatterns.Pattern.Structural.Decorator {
  public class DecoratorPatternSample : IDesignPatternSample {
    public void ShowSample() {
      AbstractBeverage tea = new Tea();
      AbstractBeverage teaWithChocolate = new ChocolateBeverageAddonDecorator(new Tea());
      Console.WriteLine($"{nameof(AbstractBeverage)} Tea price: {tea}");
      Console.WriteLine($"{nameof(AbstractBeverage)} tea with chocolate addon price: {teaWithChocolate}");
    }
  }
}
