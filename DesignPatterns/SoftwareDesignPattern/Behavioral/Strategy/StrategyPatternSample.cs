using DesignPatterns.SoftwareDesignPattern.Behavioral.Strategy.FlyStrategy;

namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Strategy {
  public class StrategyPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var duck1 = new Duck(new NoFlightStrategy());
      var duck2 = new Duck(new NormalFlightStrategy());

      duck1.Fly();
      duck2.Fly();
    }
  }
}
