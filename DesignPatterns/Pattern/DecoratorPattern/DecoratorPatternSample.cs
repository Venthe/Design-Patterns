using System;
using DesignPatterns.Pattern.DecoratorPattern.Beverages;
using DesignPatterns.Pattern.DecoratorPattern.Decorators;

namespace DesignPatterns.Pattern.DecoratorPattern {
  public class DecoratorPatternSample : IDesignPatternSample {
    public void ShowSample() {
      AbstractBeverage tea = new Tea();
      AbstractBeverage teaWithChocolate = new ChocolateBeverageAddonDecorator(new Tea());
      Console.Out.WriteLine($"{nameof(AbstractBeverage)} Tea price: {tea}");
      Console.Out.WriteLine($"{nameof(AbstractBeverage)} tea with chocolate addon price: {teaWithChocolate}");
    }
  }
}
