using DesignPatterns.SoftwareDesignPattern.Structural.Facade.ComplexSystem;

namespace DesignPatterns.SoftwareDesignPattern.Structural.Facade {
  public class ComplexSystemFacade {
    public static void UseMethodBehindFacade(string argument) {
      var system = new ComplexSystemEntryPoint(null, null, null);

      system.MethodThatHasToBeCalledFirst();
      system.MethodThatHasToBeCalledWithVariable(argument);
      system.MethodThatHasToBeCalledLast();
    }
  }
}
