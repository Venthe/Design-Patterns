namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Iterator {
  public interface IIteratee<T> {
    IIterator<T> GetIterator();
  }
}
