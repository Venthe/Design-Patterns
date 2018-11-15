using System;

namespace DesignPatterns.Pattern.Behavioral.TemplateMethod {
  // Defines the skeleton of an Algorithm in a operation deferring some steps to subclases.
  // Template method lets subclasses redefine certain steps of the algorithm
  // without changing the algorithm structure.
  public class TemplateMethodPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var templateMethod = new ConcreteTemplateMethod();

      Console.WriteLine(templateMethod.TemplateMethod());
    }
  }
}
