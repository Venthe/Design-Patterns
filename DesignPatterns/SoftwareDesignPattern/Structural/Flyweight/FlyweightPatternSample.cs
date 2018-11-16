using System;
using DesignPatterns.SoftwareDesignPattern.Structural.Flyweight;

namespace DesignPatterns.SoftwareDesignPattern.Structural.FlyweightPatternSample {
  public class FlyweightPatternSample : IDesignPatternSample {
    private readonly string[] colors = { "Red", "Green", "Blue", "White", "Black" };
    private readonly Random random = new Random();

    public void ShowSample() {
      for (int i = 0; i < 50; ++i) {
        var tile = TileFlyweightFactory.ConstructTile(GetRandomColor());
        tile.X = GetRandomX();
        tile.Y = GetRandomY();
        Console.WriteLine(tile.Draw());
      }

      Console.WriteLine(TileFlyweightFactory.TilesCreatedCount);
    }

    private string GetRandomColor() => colors[random.Next(colors.Length)];

    private int GetRandomX() => random.Next(100);

    private int GetRandomY() => random.Next(100);
  }
}
