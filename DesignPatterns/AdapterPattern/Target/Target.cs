using System;

namespace DesignPatterns.AdapterPattern.Target {
  public class Target : ITarget {
    public void Publish() => Console.WriteLine("Properly called");
  }
}
