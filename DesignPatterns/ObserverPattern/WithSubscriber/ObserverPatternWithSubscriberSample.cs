using System;

namespace DesignPatterns.ObserverPattern.WithSubscriber {
  public class ObserverPatternWithSubscriberSample : IDesignPatternSample {
    private const string sampleText = "New test notification";

    public void ShowSample() {
      var observable = ObservableFactory.Of<string>();

      var observer1 = observable.Subscribe().Pipe(
         SampleTransformations.ToUpper,
         SampleTransformations.Tap(SampleTransformations.Log())
         );

      var observer2 = observable.Subscribe().Pipe(
         SampleTransformations.Map(v => v.ToString() + " appended text"),
         SampleTransformations.Tap(SampleTransformations.Log())
         );

      // Observer that we cannot manually destroy; will have to be garbage collected
      observable.Subscribe();

      Console.Out.WriteLine($"Should show text: \"{sampleText}\" mapped accordingly");
      observable.Notify(sampleText);
    }
  }
}
