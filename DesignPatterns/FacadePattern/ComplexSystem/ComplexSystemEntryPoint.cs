using System;

namespace DesignPatterns.FacadePattern.ComplexSystem {
  public class ComplexSystemEntryPoint {
    public ComplexSystemEntryPoint(object dependency, object dependency2, object dependency3) {
      Console.Out.WriteLine($"Build with dependencies: {dependency} {dependency2} {dependency3}");
    }

    public void MethodThatHasToBeCalledFirst() {
    }

    public void MethodThatHasToBeCalledWithVariable(string argument) {
      Console.Out.WriteLine(argument);
    }

    public void MethodThatHasToBeCalledLast() {
    }
  }
}
