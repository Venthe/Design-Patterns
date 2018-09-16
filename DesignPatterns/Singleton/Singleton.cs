namespace DesignPatterns.Singleton {
  class Singleton {
    private Singleton instance;

    private Singleton() { }

    public Singleton GetInstance() => instance ?? (instance = new Singleton());
  }
}
