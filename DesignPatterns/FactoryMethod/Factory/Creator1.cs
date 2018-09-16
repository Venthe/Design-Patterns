namespace DesignPatterns.FactoryMethod.Factory {
  // Should be only used as concrete factory method
  class Creator1 {
    public IProduct FactoryMethod() => new Product();
    public void OtherStuff() => throw new System.NotImplementedException();
  }
}
