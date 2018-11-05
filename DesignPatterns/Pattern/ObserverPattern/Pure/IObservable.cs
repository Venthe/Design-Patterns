namespace DesignPatterns.Pattern.ObserverPattern.Pure {
  public interface IObservable {
    void Subscribe(IObserver observer);

    void Unsubscribe(IObserver observer);

    void Notify();
  }
}
