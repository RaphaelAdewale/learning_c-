using System;

// Implementing multiple inheritance
public interface IA
{
    void PrintA();
}

public class A : IA
{
    public void PrintA()
    {
        Console.WriteLine("This is A");
    }
}

public interface IB
{
    void PrintB();
}

public class B : IB
{
    public void PrintB()
    {
        Console.WriteLine("This is B");
    }
}

public class AB : IA, IB
{
    A a = new A();
    B b = new B();

    public void PrintA()
    {
        a.PrintA();
    }

    public void PrintB()
    {
        b.PrintB();
    }
}