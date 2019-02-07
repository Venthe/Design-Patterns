## Singleton pattern

The singleton pattern is a way to make sure that only one instance of a type can be created. The pattern usually fills the same purpose as a static classes but with the added utility that the class can be a derived class, it can implement interfaces, and it be passes as method parameter.

A singleton getter is implemented as either a static property or a static getter-method.

    //As a method
    private static SingletonType _theSingletonInstance;

    public static SingletonType GetSingletonInstance(){
        if(null == _theSingletonInstance)
            _theSingletonInstance();
        
        return _theSingletonInstance();
    }

    //As a property (using lambda expression)
    public static SingletonType SingletonInstance => null != _singletonInstance ? _singletonInstance : (_singletonInstance = new SingletonInstance())

When using the singleton pattern, it's usually implied that consumers should be prohibited from creating more than one instance by accident. This can be achieved by not having any public constructors and making the default constructor private. 
