namespace DesignPatterns.Pattern.ObserverPattern.WithData {
  public interface IObserver<T> {
    void Update(T data);
  }
}
