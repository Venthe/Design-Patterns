#pragma warning disable CC0091 // Use static method
namespace DesignPatterns.SoftwareDesignPattern.Creational.Singleton {
  public class SampleSingleton {
    private static SampleSingleton instance;

    public SampleSingleton GetInstance() => instance ?? (instance = new SampleSingleton());
  }
}
