﻿using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.SoftwareDesignPattern.Structural.Composite {
  public class CompositeContainer : IComposite {
    public string Name => string.Join(" ", (from child in Children select child.Name).ToList());

    public ICollection<IComposite> Children { get; } = new List<IComposite>();
  }
}
