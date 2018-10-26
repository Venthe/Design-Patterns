using System;

namespace DesignPatterns.ObserverPattern.WithSubscriber {
  public interface IObserver<T> {
    void Update(T data);
    void Unsubscribe();
    void Register(IObservable<T> observable);
    IObserver<T> Pipe(params Func<dynamic, dynamic>[] transformations);
  }
}
