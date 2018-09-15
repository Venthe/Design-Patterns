using System;

namespace DesignPatterns.Observer.WithSubscriber
{
   static class ObservableFactory
   {
      public static IObservable<T> Of<T>() => new Observable<T>();
   }
}
