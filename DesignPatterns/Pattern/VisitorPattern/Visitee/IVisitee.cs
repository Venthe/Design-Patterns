namespace DesignPatterns.Pattern.VisitorPattern.Visitee {
  public interface IVisitee {
    void Accept(IPersonVisitor visitor);
  }
}
