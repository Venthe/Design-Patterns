using System;
using DesignPatterns.Pattern.Behavioral.Visitor.Visitee;
using DesignPatterns.Pattern.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Pattern.Behavioral.Visitor {
  public class VisitorPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var person = new Person();

      person.Assets.Add(new BankAccount(100, 1.2));
      person.Assets.Add(new BankAccount(30, 1.1));
      person.Assets.Add(new BankAccount(80, 1.4));
      person.Assets.Add(new Loan(80, 100));
      person.Assets.Add(new RealEstate(8, 10));

      var netWorthVisitor = new NetWorthVisitor();
      person.Accept(netWorthVisitor);

      var incomeVisitor = new IncomeVisitor();
      person.Accept(incomeVisitor);

      Console.WriteLine($"NetWorthVisitor got {netWorthVisitor.NetWorth}");
      Console.WriteLine($"IncomeVisitor got {incomeVisitor.Income}");
    }
  }
}
