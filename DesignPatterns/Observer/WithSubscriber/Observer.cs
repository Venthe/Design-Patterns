using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer.WithSubscriber
{
   class Observer<T> : IObserver<T>
   {
      private IObservable<T> observable;
      private Func<dynamic, dynamic>[] transformations;

      public void Register(IObservable<T> observable) => this.observable = observable;
      public void Unsubscribe() => observable.Unsubscribe(this);
      public void Update(T data)
      {
         T State = data;
         if (transformations != null && transformations.Length != 0)
         {
            new List<Func<dynamic, dynamic>>(transformations).ForEach(transformation => State = transformation(State));
         }
      }

      public IObserver<T> Pipe(params Func<dynamic, dynamic>[] transformations)
      {
         this.transformations = transformations;
         return this;
      }
   }
}
