namespace DesignPatterns.SoftwareDesignPattern.Structural.Flyweight {
  public interface ITile {
    string Color { get; }

    int X { get; set; }

    int Y { get; set; }

    string Draw();
  }
}
