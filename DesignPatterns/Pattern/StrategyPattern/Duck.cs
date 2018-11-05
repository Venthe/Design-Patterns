using System;
using DesignPatterns.Pattern.StrategyPattern.FlyStrategy;

namespace DesignPatterns.Pattern.StrategyPattern {
  public class Duck : IDuck {
    private readonly IFlyStrategy flyStrategy;

    public Duck(IFlyStrategy flyStrategy) {
      this.flyStrategy = flyStrategy;
    }

    public void Fly() {
      Console.WriteLine($"Duck with \"{flyStrategy.Fly()}\" flying strategy");
    }
  }
}
