using System.Collections.Generic;

namespace DesignPatterns.Observer.WithSubscriber {
  class Observable<T> : IObservable<T> {
    private ICollection<IObserver<T>> observers;

    public Observable() => this.observers = new List<IObserver<T>>();

    public void Notify(T data) {
      foreach (var observer in observers) {
        observer.Update(data);
      }
    }

    public void Unsubscribe(IObserver<T> observer) => observers.Remove(observer);

    public IObserver<T> Subscribe(IObserver<T> observer) {
      observers.Add(observer);
      observer.Register(this);
      return observer;
    }

    public IObserver<T> Subscribe() {
      var newObservable = new Observer<T>();
      this.Subscribe(newObservable);
      return newObservable;
    }
  }
}
