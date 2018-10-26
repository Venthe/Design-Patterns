using System;

namespace DesignPatterns.StrategyPattern.FlyStrategy {
  public class NoFlightStrategy : IFlyStrategy {
    public void Fly() => Console.WriteLine("No flight");
  }
}
