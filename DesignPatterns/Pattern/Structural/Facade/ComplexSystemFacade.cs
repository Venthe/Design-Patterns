using DesignPatterns.Pattern.Structural.Facade.ComplexSystem;

namespace DesignPatterns.Pattern.Structural.Facade {
  public class ComplexSystemFacade {
    public static void UseMethodBehindFacade(string argument) {
      var system = new ComplexSystemEntryPoint(null, null, null);

      system.MethodThatHasToBeCalledFirst();
      system.MethodThatHasToBeCalledWithVariable(argument);
      system.MethodThatHasToBeCalledLast();
    }
  }
}
