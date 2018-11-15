using System.Collections.Generic;
using DesignPatterns.SoftwareDesignPattern.Behavioral.Visitor.Visitee;
using DesignPatterns.SoftwareDesignPattern.Behavioral.Visitor.Visitor;

namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Visitor {
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
