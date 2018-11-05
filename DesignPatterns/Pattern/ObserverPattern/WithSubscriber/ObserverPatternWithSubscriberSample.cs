using System;

namespace DesignPatterns.Pattern.ObserverPattern.WithSubscriber {
  public class ObserverPatternWithSubscriberSample : IDesignPatternSample {
    private const string SampleText = "New test notification";

    public void ShowSample() {
      var observable = ObservableFactory.Of<string>();

      var observer1 = observable.Subscribe().Pipe(
         SampleTransformations.ToUpper,
         SampleTransformations.Tap(SampleTransformations.Log())
         );

      var observer2 = observable.Subscribe().Pipe(
         SampleTransformations.Map(v => $"{v} appended text"),
         SampleTransformations.Tap(SampleTransformations.Log())
         );

      // Observer that we cannot manually destroy; will have to be garbage collected
      observable.Subscribe();

      Console.Out.WriteLine($"Should show text: \"{SampleText}\" mapped accordingly");
      observable.Notify(SampleText);
    }
  }
}
