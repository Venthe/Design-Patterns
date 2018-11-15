using System;

#pragma warning disable CC0091 // Use static method
namespace DesignPatterns.SoftwareDesignPattern.Structural.Facade.ComplexSystem {
  public class ComplexSystemEntryPoint {
    public ComplexSystemEntryPoint(object dependency, object dependency2, object dependency3) {
      Console.WriteLine($"Build with dependencies: {dependency} {dependency2} {dependency3}");
    }

    public void MethodThatHasToBeCalledFirst() {
    }

    public void MethodThatHasToBeCalledWithVariable(string argument) {
      Console.WriteLine(argument);
    }

    public void MethodThatHasToBeCalledLast() {
    }
  }
}
