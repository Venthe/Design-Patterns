using System;

namespace DesignPatterns.AdapterPattern.Target {
  public class NonAdaptedTarget : ITarget {
    public void Publish() => Console.WriteLine("Properly called");
  }
}
