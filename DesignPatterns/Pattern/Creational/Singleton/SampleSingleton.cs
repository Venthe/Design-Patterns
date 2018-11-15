namespace DesignPatterns.Pattern.Creational.Singleton {
  public class SampleSingleton {
    private static SampleSingleton instance;

    public SampleSingleton GetInstance() => instance ?? (instance = new SampleSingleton());
  }
}
