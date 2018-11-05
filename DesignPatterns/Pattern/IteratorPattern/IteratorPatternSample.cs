using System;

namespace DesignPatterns.Pattern.IteratorPattern {
  public class IteratorPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var iteratee = new ConcreteIteratee<int>(1, 2, 3, 4, 5);
      for (var iterator = iteratee.GetIterator(); iterator.HasNext(); iterator.Next()) {
        Console.WriteLine(iterator.Value);
      }
    }
  }
}
