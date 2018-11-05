namespace DesignPatterns.Pattern.IteratorPattern {
  public interface IIterator<T> {
    T Value { get; }

    bool HasNext();

    void Next();
  }
}
