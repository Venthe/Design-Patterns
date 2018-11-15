using System.Collections.Generic;
using DesignPatterns.Pattern.VisitorPattern.Visitee;

namespace DesignPatterns.Pattern.VisitorPattern {
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
