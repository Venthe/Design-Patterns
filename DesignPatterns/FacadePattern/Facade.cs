using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.FacadePattern.ComplexSystem;

namespace DesignPatterns.FacadePattern {
  public class Facade {
    public void UseMethodBehindFacade(string argument) {
      var system = new ComplexSystemEntryPoint(null, null, null);

      system.MethodThatHasToBeCalledFirst();
      system.MethodThatHasToBeCalledWithVariable(argument);
      system.MethodThatHasToBeCalledLast();
    }
  }
}
