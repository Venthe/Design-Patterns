using DesignPatterns.SoftwareDesignPattern.Behavioral.Visitor.Visitor;

namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Visitor.Visitee {
  public interface IVisitee {
    void Accept(IPersonVisitor visitor);
  }
}
