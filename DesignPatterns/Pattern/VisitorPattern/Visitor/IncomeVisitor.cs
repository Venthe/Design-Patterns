using DesignPatterns.Pattern.VisitorPattern.Visitee;

namespace DesignPatterns.Pattern.VisitorPattern.Visitor {
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
