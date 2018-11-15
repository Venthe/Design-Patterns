using DesignPatterns.SoftwareDesignPattern.Behavioral.Visitor.Visitee;

namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Visitor.Visitor {
  public interface IPersonVisitor {
    void Visit(RealEstate realEstate);

    void Visit(BankAccount bankAccount);

    void Visit(Loan loan);
  }
}
