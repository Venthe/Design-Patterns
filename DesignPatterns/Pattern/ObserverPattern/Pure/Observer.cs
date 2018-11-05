using System;

namespace DesignPatterns.Pattern.ObserverPattern.Pure {
  public class Observer : IObserver {
    public void Update() => Console.WriteLine("Update has been called");
  }
}
