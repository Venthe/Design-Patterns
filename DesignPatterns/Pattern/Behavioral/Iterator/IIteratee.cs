namespace DesignPatterns.Pattern.Behavioral.Iterator {
  public interface IIteratee<T> {
    IIterator<T> GetIterator();
  }
}
