namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Iterator {
  public class ConcreteIteratee<T> : IIteratee<T> {
    public ConcreteIteratee(params T[] data) {
      Data = data;
    }

    public T[] Data { get; }

    public IIterator<T> GetIterator() {
      return new ConcreteIterator<T>(this);
    }
  }
}
