using System;

namespace DesignPatterns.Pattern.Behavioral.TemplateMethod {
  public abstract class AbstractTemplateMethod {
    public string TemplateMethod() {
      string wrapInBrackets(string txt) => $"[{txt}]";

      var text = default(string);

      // ...
      text += wrapInBrackets(Operation1());

      // ...
      text += wrapInBrackets(Operation2());

      // ...
      return text;
    }

    protected virtual string Operation1() => throw new NotImplementedException();

    protected virtual string Operation2() => throw new NotImplementedException();
  }
}
