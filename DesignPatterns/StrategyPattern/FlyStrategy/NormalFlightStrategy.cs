using System;

namespace DesignPatterns.StrategyPattern.FlyStrategy {
  public class NormalFlightStrategy : IFlyStrategy {
    public void Fly() => Console.WriteLine("Normal flight");
  }
}
