namespace DesignPatterns.Pattern.ObserverPattern.WithData {
  public interface IObservable<T> {
    void Subscribe(IObserver<T> observer);

    void Unsubscribe(IObserver<T> observer);

    void Notify(T data);
  }
}
