using DesignPatterns.Pattern.StrategyPattern.FlyStrategy;

namespace DesignPatterns.Pattern.StrategyPattern {
  public class StrategyPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var duck1 = new Duck(new NoFlightStrategy());
      var duck2 = new Duck(new NormalFlightStrategy());

      duck1.Fly();
      duck2.Fly();
    }
  }
}
