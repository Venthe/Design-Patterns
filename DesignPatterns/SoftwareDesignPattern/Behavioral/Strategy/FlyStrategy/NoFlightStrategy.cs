namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Strategy.FlyStrategy {
  public class NoFlightStrategy : IFlyStrategy {
    public string Fly() => "No flight";
  }
}
