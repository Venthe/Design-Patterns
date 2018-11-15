using DesignPatterns.Pattern.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Pattern.Behavioral.Visitor.Visitee {
  public class Loan : IVisitee {
    public Loan(int estimatedValue, int monthlyRent) {
      EstimatedValue = estimatedValue;
      MonthlyRent = monthlyRent;
    }

    public int EstimatedValue { get; }

    public int MonthlyRent { get; }

    public void Accept(IPersonVisitor visitor) {
      visitor.Visit(this);
    }
  }
}
