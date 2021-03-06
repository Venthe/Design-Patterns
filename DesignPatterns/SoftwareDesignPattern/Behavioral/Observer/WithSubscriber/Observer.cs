﻿using System;
using System.Collections.Generic;

namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Observer.WithSubscriber {
  public class Observer<T> : IObserver<T> {
    private IObservable<T> observable;
    private Func<dynamic, dynamic>[] transformations;

    public void Register(IObservable<T> observable) => this.observable = observable;

    public void Unsubscribe() => observable.Unsubscribe(this);

    public void Update(T data) {
      var state = data;
      if (transformations != null && transformations.Length != 0) {
        new List<Func<dynamic, dynamic>>(transformations)
          .ForEach(transformation => state = transformation?.Invoke(state));
      }
    }

    // TODO: Pass Frame and not data alone
    // {type: completed|error|value, frame: frameNo, data: actualData}
    public IObserver<T> Pipe(params Func<dynamic, dynamic>[] transformations) {
      this.transformations = transformations;
      return this;
    }
  }
}
