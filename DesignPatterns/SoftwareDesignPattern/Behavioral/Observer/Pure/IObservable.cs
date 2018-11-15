namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Observer.Pure {
  public interface IObservable {
    void Subscribe(IObserver observer);

    void Unsubscribe(IObserver observer);

    void Notify();
  }
}
