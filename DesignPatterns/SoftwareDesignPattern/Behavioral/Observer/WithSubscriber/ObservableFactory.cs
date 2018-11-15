namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Observer.WithSubscriber {
  public static class ObservableFactory {
    public static IObservable<T> Of<T>() => new Observable<T>();
  }
}
