using System;

namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Observer.Pure {
  public class Observer : IObserver {
    public void Update() => Console.WriteLine("Update has been called");
  }
}
