namespace DesignPatterns.Pattern.IteratorPattern {
  public interface IIteratee<T> {
    IIterator<T> GetIterator();
  }
}
