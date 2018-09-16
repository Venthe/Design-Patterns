using System.Collections.Generic;

namespace DesignPatterns.Observer.Pure {
  class Observable : IObservable {
    private ICollection<IObserver> observers;

    public Observable() => this.observers = new List<IObserver>();

    public void Notify() {
      foreach (var observer in observers) {
        observer.Update();
      }
    }

    public void Subscribe(IObserver observer) => observers.Add(observer);

    public void Unsubscribe(IObserver observer) => observers.Remove(observer);
  }
}
