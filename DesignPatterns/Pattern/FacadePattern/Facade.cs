using DesignPatterns.Pattern.FacadePattern.ComplexSystem;

namespace DesignPatterns.Pattern.FacadePattern {
  public class Facade {
    public static void UseMethodBehindFacade(string argument) {
      var system = new ComplexSystemEntryPoint(null, null, null);

      system.MethodThatHasToBeCalledFirst();
      system.MethodThatHasToBeCalledWithVariable(argument);
      system.MethodThatHasToBeCalledLast();
    }
  }
}
