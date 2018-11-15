using System;

namespace DesignPatterns.SoftwareDesignPattern.Structural.Adapter.Target {
  public class NonAdaptedTarget : ITarget {
    public void Publish() => Console.WriteLine("Properly called");
  }
}
