namespace DesignPatterns.Observer.Pure
{
   interface IObservable
   {
      void Subscribe(IObserver observer);
      void Unsubscribe(IObserver observer);
      void Notify();
   }
}
