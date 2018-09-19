using System;

namespace DesignPatterns.Adapter.Target {
  class Target : ITarget {
    public void Publish() => Console.WriteLine("Properly called");
  }
}
