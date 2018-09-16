namespace DesignPatterns.Observer.WithData {
  interface IObserver<T> {
    void Update(T data);
  }
}
