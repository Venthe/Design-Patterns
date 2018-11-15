using DesignPatterns.Pattern.Behavioral.Visitor.Visitee;

namespace DesignPatterns.Pattern.Behavioral.Visitor.Visitor {
  public class NetWorthVisitor : IPersonVisitor {
    public int NetWorth { get; private set; }

    public void Visit(RealEstate realEstate) {
      NetWorth += realEstate.MonthlyPayment;
    }

    public void Visit(BankAccount bankAccount) {
      NetWorth += bankAccount.Amount;
    }

    public void Visit(Loan loan) {
      NetWorth -= loan.MonthlyRent;
    }
  }
}
