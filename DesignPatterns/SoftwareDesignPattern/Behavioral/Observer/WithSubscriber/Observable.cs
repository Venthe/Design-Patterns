using System.Collections.Generic;

namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Observer.WithSubscriber {
  public class Observable<T> : IObservable<T> {
    private ICollection<IObserver<T>> observers;

    public Observable() => observers = new List<IObserver<T>>();

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
      Subscribe(newObservable);
      return newObservable;
    }
  }
}
