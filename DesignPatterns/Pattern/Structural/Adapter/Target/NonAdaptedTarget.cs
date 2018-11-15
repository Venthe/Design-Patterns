using System;

namespace DesignPatterns.Pattern.Structural.Adapter.Target {
  public class NonAdaptedTarget : ITarget {
    public void Publish() => Console.WriteLine("Properly called");
  }
}
