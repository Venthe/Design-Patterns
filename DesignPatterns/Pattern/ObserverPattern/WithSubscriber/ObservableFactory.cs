namespace DesignPatterns.Pattern.ObserverPattern.WithSubscriber {
  public static class ObservableFactory {
    public static IObservable<T> Of<T>() => new Observable<T>();
  }
}
