using System.Collections.Generic;

namespace DesignPatterns.SoftwareDesignPattern.Structural.Flyweight {
  public class TileFlyweightFactory {
    public static int TilesCreatedCount => Tiles.Count;

    private static IDictionary<string, ITile> Tiles { get; } = new Dictionary<string, ITile>();

    public static ITile ConstructTile(string color) => Tiles.ContainsKey(color) ? Tiles[color] : CreateTileAndAddToCache(color);

    private static ITile CreateTileAndAddToCache(string color) {
      ITile tile = new Tile(color);
      Tiles.Add(color, tile);
      return tile;
    }
  }
}
