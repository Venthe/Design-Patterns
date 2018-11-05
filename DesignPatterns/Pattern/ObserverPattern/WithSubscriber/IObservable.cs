namespace DesignPatterns.Pattern.ObserverPattern.WithSubscriber {
  public interface IObservable<T> {
    IObserver<T> Subscribe(IObserver<T> observer);

    IObserver<T> Subscribe();

    void Notify(T data);

    void Unsubscribe(IObserver<T> observer);
  }
}
