using System;

namespace DesignPatterns.Observer.Pure {
  class Observer : IObserver {
    public void Update() => Console.Out.WriteLine("Update has been called");
  }
}
