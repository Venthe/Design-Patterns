namespace DesignPatterns.SoftwareDesignPattern.Creational.Builder {
  public interface ICar {
    string Maker { get; }

    string Model { get; }

    int Doors { get; }

    double EngineVolume { get; }
  }
}
