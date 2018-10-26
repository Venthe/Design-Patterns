using System;

namespace DesignPatterns.ObserverPattern.Pure {
  public class Observer : IObserver {
    public void Update() => Console.Out.WriteLine("Update has been called");
  }
}
