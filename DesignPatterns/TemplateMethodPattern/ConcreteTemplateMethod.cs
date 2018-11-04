using System;

namespace DesignPatterns.TemplateMethodPattern {

  public class ConcreteTemplateMethod : AbstractTemplateMethod {
    protected override string Operation1() => "Operation1 as defined by concrete implementation";
    protected override string Operation2() => "Operation2 as defined by concrete implementation";
  }
}
