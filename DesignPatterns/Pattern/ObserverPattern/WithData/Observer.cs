using System;

namespace DesignPatterns.Pattern.ObserverPattern.WithData {
  public class Observer<T> : IObserver<T> {
    public void Update(T data) => Console.WriteLine($"[{GetHashCode()}] Update has been called with {data}");
  }
}
