namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Iterator {
  public interface IIterator<T> {
    T Value { get; }

    bool HasNext();

    void Next();
  }
}
