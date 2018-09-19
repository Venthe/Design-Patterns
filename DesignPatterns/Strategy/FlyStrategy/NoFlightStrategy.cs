using System;

namespace DesignPatterns.Strategy.FlyStrategy {
  class NoFlightStrategy : IFlyStrategy {
    public void Fly() => Console.WriteLine("No flight");
  }
}
