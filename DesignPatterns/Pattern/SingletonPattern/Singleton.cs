namespace DesignPatterns.Pattern.SingletonPattern {
  public class Singleton {
    private static Singleton instance;

    public Singleton GetInstance() => instance ?? (instance = new Singleton());
  }
}
