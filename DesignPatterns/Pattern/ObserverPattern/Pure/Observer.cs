using System;

namespace DesignPatterns.Pattern.ObserverPattern.Pure {
  public class Observer : IObserver {
    public void Update() => Console.Out.WriteLine("Update has been called");
  }
}
