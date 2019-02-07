#pragma warning disable CC0091 // Use static method
namespace DesignPatterns.SoftwareDesignPattern.Creational.Singleton {
  public class SampleSingleton {

    private SampleSingleton(){
      //Declaring a private constructor prevents the consumer from accidentally creating more than one instance of the class.
      //The only way to create an instance object of the type is by calling SampleSingleton.GetInstance() 
    }

    private static SampleSingleton instance;

    //A new SampleSingleton object is created on the first call to GetInstance and stored internally. Subsequent calls will return the stored instance.
    public static SampleSingleton GetInstance() => instance ?? (instance = new SampleSingleton());
  }
}
