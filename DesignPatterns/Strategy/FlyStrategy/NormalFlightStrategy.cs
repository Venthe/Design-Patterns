using System;
using DesignPatterns.Strategy.FlyStrategy;

namespace DesignPatterns.Strategy {
  class NormalFlightStrategy : IFlyStrategy {
    public void Fly() => Console.WriteLine("Normal flight");
  }
}
