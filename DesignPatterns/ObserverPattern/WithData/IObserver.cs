namespace DesignPatterns.ObserverPattern.WithData {
  public interface IObserver<T> {
    void Update(T data);
  }
}
