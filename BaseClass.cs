using System;

public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("This is a Baseclass");
    }
}

public class DerivedClass : BaseClass
{
    public new void Print()
    {
        Console.WriteLine("This is a Derivedclass");
    }
}
