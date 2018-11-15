namespace DesignPatterns.Pattern.Behavioral.Observer.Pure {
  public interface IObservable {
    void Subscribe(IObserver observer);

    void Unsubscribe(IObserver observer);

    void Notify();
  }
}
