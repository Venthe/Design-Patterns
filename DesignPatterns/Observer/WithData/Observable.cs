using System.Collections.Generic;

namespace DesignPatterns.Observer.WithData {
  class Observable<T> : IObservable<T> {
    private ICollection<IObserver<T>> observers;

    public Observable() => this.observers = new List<IObserver<T>>();

    public void Notify(T data) {
      foreach (var observer in observers) {
        observer.Update(data);
      }
    }

    public void Subscribe(IObserver<T> observer) => observers.Add(observer);

    public void Unsubscribe(IObserver<T> observer) => observers.Remove(observer);
  }
}
