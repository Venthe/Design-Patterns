using DesignPatterns.SoftwareDesignPattern.Behavioral.Visitor.Visitor;

namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Visitor.Visitee {
  public class RealEstate : IVisitee {
    public RealEstate(int monthlyPayment, int owned) {
      MonthlyPayment = monthlyPayment;
      Owned = owned;
    }

    public int MonthlyPayment { get; }

    public int Owned { get; }

    public void Accept(IPersonVisitor visitor) {
      visitor.Visit(this);
    }
  }
}
