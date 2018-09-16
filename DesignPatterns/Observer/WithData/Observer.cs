using System;

namespace DesignPatterns.Observer.WithData {
  class Observer<T> : IObserver<T> {
    public void Update(T data) => Console.Out.WriteLine($"[{this.GetHashCode()}] Update has been called with {data}");
  }
}
