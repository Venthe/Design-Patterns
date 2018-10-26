using System;

namespace DesignPatterns.ObserverPattern.WithData {
  public class Observer<T> : IObserver<T> {
    public void Update(T data) => Console.Out.WriteLine($"[{GetHashCode()}] Update has been called with {data}");
  }
}
