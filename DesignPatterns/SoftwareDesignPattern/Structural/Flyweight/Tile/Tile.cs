using System;

namespace DesignPatterns.SoftwareDesignPattern.Structural.Flyweight {
  public class Tile : ITile {
    public Tile(string color) {
      Color = color;
    }

    public string Color { get; }

    public int X { get; set; } = default(int);

    public int Y { get; set; } = default(int);

    public string Draw() => $"{Color}: X: {X}, Y: {Y}";
  }
}
