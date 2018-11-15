using System.Collections.Generic;
using DesignPatterns.Pattern.Behavioral.Visitor.Visitee;
using DesignPatterns.Pattern.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Pattern.Behavioral.Visitor {
  // This class cannot be chan
  public class Person : IVisitee {
    public List<IVisitee> Assets { get; } = new List<IVisitee>();

    public void Accept(IPersonVisitor visitor) {
      foreach (var asset in Assets) {
        asset.Accept(visitor);
      }
    }
  }
}
