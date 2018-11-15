using System;

namespace DesignPatterns.Pattern.Behavioral.Observer.Pure {
  public class Observer : IObserver {
    public void Update() => Console.WriteLine("Update has been called");
  }
}
