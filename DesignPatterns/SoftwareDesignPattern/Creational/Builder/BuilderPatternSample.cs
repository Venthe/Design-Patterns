#pragma warning disable CC0008

using System;

namespace DesignPatterns.SoftwareDesignPattern.Creational.Builder {
  // Separate the construction of a complex object from its representation. It's used preferentially to add parameters step by step with construction as a final step
  public class BuilderPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var sport = new FerrariBuilder { Colour = "red", NumDoors = 2 }.Build();
      Console.WriteLine(sport);

      var coupe = new FerrariBuilder { Colour = "blue", NumDoors = 4 }.Build();
      Console.WriteLine(coupe);

      var coupeBuilder = new FerrariBuilder { Colour = "orange" };
      coupeBuilder.Colour = "yellow";
      coupeBuilder.NumDoors = 5;
      var coupe2 = coupeBuilder.Build();
      Console.WriteLine(coupe2);
    }
  }
}
