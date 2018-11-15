using DesignPatterns.Pattern.Behavioral.Visitor.Visitee;

namespace DesignPatterns.Pattern.Behavioral.Visitor.Visitor {
  public interface IPersonVisitor {
    void Visit(RealEstate realEstate);

    void Visit(BankAccount bankAccount);

    void Visit(Loan loan);
  }
}
