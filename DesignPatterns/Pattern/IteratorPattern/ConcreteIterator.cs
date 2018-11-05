namespace DesignPatterns.Pattern.IteratorPattern {
  public class ConcreteIterator<T> : IIterator<T> {
    private readonly ConcreteIteratee<T> iteratee;
    private readonly int totalLength;
    private int currentIndex;

    public ConcreteIterator(ConcreteIteratee<T> iteratee) {
      this.iteratee = iteratee;
      totalLength = this.iteratee.Data.Length;
      currentIndex = 0;
    }

    public T Value => iteratee.Data[currentIndex];

    public bool HasNext() => currentIndex < totalLength;

    public void Next() => currentIndex++;
  }
}
