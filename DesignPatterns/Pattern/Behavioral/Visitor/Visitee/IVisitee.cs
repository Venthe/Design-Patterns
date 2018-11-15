using DesignPatterns.Pattern.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Pattern.Behavioral.Visitor.Visitee {
  public interface IVisitee {
    void Accept(IPersonVisitor visitor);
  }
}
