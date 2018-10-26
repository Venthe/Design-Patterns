namespace DesignPatterns.SingletonPattern {
  public class Singleton {
    private static Singleton instance;

    public Singleton GetInstance() => instance ?? (instance = new Singleton());
  }
}
