using DesignPatterns.Pattern.VisitorPattern.Visitee;

namespace DesignPatterns.Pattern.VisitorPattern {
  public interface IPersonVisitor {
    void Visit(RealEstate realEstate);

    void Visit(BankAccount bankAccount);

    void Visit(Loan loan);
  }
}
