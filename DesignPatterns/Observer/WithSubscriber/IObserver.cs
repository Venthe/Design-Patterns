using System;

namespace DesignPatterns.Observer.WithSubscriber
{
   interface IObserver<T>
   {
      void Update(T data);
      void Unsubscribe();
      void Register(IObservable<T> observable);
      IObserver<T> Pipe(params Func<dynamic, dynamic>[] transformations);
   }
}
