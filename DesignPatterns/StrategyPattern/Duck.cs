using DesignPatterns.StrategyPattern.FlyStrategy;

namespace DesignPatterns.StrategyPattern {
  public class Duck : IDuck {
    private readonly IFlyStrategy flyStrategy;

    public Duck(IFlyStrategy flyStrategy) {
      this.flyStrategy = flyStrategy;
    }

    public void Fly() => flyStrategy.Fly();
  }
}
