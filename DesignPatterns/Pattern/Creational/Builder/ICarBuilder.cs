namespace DesignPatterns.Pattern.Creational.Builder {
  public interface ICarBuilder {
    string Colour { get; set; }

    int NumDoors { get; set; }

    ICar Build();
  }
}
