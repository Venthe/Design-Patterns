using DesignPatterns.SoftwareDesignPattern.Behavioral.Visitor.Visitee;

namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Visitor.Visitor {
  public class IncomeVisitor : IPersonVisitor {
    public double Income { get; private set; }

    public void Visit(RealEstate realEstate) {
      Income += realEstate.Owned;
    }

    public void Visit(BankAccount bankAccount) {
      Income += bankAccount.Amount * bankAccount.MonthlyInterest;
    }

    public void Visit(Loan loan) {
    }
  }
}
