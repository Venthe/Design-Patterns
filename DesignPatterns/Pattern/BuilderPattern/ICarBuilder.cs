namespace DesignPatterns.Pattern.BuilderPattern {
  public interface ICarBuilder {
    string Colour { get; set; }

    int NumDoors { get; set; }

    ICar Build();
  }
}
