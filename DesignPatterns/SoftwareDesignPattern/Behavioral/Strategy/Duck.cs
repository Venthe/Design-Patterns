using System;
using DesignPatterns.SoftwareDesignPattern.Behavioral.Strategy.FlyStrategy;

namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Strategy {
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
