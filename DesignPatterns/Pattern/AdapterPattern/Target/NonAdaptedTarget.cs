using System;

namespace DesignPatterns.Pattern.AdapterPattern.Target {
  public class NonAdaptedTarget : ITarget {
    public void Publish() => Console.WriteLine("Properly called");
  }
}
