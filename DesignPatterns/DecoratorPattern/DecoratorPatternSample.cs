using System;
using DesignPatterns.DecoratorPattern.Beverages;
using DesignPatterns.DecoratorPattern.Decorators;

namespace DesignPatterns.DecoratorPattern {
  public class DecoratorPatternSample : IDesignPatternSample {
    public void ShowSample() {
      AbstractBeverage tea = new Tea();
      AbstractBeverage teaWithChocolate = new ChocolateBeverageAddonDecorator(new Tea());
      Console.Out.WriteLine($"Tea: {tea}, tea with chocolate {teaWithChocolate}");
    }
  }
}
