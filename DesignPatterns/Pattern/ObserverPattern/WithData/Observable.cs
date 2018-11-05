using System.Collections.Generic;

namespace DesignPatterns.Pattern.ObserverPattern.WithData {
  public class Observable<T> : IObservable<T> {
    private ICollection<IObserver<T>> observers;

    public Observable() => observers = new List<IObserver<T>>();

    public void Notify(T data) {
      foreach (var observer in observers) {
        observer.Update(data);
      }
    }

    public void Subscribe(IObserver<T> observer) => observers.Add(observer);

    public void Unsubscribe(IObserver<T> observer) => observers.Remove(observer);
  }
}
