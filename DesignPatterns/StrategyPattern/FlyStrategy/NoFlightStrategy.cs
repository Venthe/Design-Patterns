namespace DesignPatterns.StrategyPattern.FlyStrategy {
  public class NoFlightStrategy : IFlyStrategy {
    public string Fly() => "No flight";
  }
}
