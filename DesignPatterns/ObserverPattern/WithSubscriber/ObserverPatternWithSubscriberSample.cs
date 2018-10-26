namespace DesignPatterns.ObserverPattern.WithSubscriber {
  public class ObserverPatternWithSubscriberSample : IDesignPatternSample {
    public void ShowSample() {
      var observable = ObservableFactory.Of<string>();

      var observer1 = observable.Subscribe().Pipe(
         SampleTransformations.ToUpper,
         SampleTransformations.Tap(SampleTransformations.Log())
         );

      var observer2 = observable.Subscribe().Pipe(
         SampleTransformations.Map(v => v.ToString() + " New text"),
         SampleTransformations.Tap(SampleTransformations.Log())
         );

      observable.Subscribe();

      observable.Notify("New test notification");
    }
  }
}
