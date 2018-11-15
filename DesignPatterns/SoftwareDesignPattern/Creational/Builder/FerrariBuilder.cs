namespace DesignPatterns.SoftwareDesignPattern.Creational.Builder {
  public class FerrariBuilder : ICarBuilder {
    public string Colour { get; set; }

    public int NumDoors { get; set; }

    public ICar Build() => NumDoors == 2 ? new Car(NumDoors, 2.2, "Ferrari", "Sport") : new Car(NumDoors, 1.2, "Ferrari", "Coupe");
  }
}
