using DesignPatterns.Strategy.FlyStrategy;

namespace DesignPatterns.Strategy {
  class Duck : IDuck {
    readonly IFlyStrategy flyStrategy;

    public Duck(IFlyStrategy flyStrategy) {
      this.flyStrategy = flyStrategy;
    }

    public void Fly() => flyStrategy.Fly();

    // Factory method
    public static IDuck RubberDuckFactory() => new Duck(new NoFlightStrategy());
    public static IDuck NormalDuckFactory() => new Duck(new NormalFlightStrategy());
  }
}
