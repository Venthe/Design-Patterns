namespace DesignPatterns.Pattern.Creational.Builder {
  public class Car : ICar {
    public Car(int doors, double engineVolume, string maker, string model) {
      Doors = doors;
      EngineVolume = engineVolume;
      Maker = maker;
      Model = model;
    }

    public int Doors { get; }

    public double EngineVolume { get; }

    public string Maker { get; }

    public string Model { get; }

    public override string ToString() => $"{Maker} {Model}, {Doors} doors, {EngineVolume} engine volume";
  }
}
