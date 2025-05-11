/*
📌 Definition:
A class implements an interface, meaning it provides actual definitions for all the methods defined by the interface.

🧠 Purpose:
Achieve abstraction and polymorphism

Define contracts

Promote loose coupling

🎯 Real-World Analogy:
A Printer promises to fulfill the "Print" behavior, just like any brand of printer must support the standard "print" function.
*/

public interface IPrintable
{
    void Print();
}

public class Printer : IPrintable
{
    public void Print() => Console.WriteLine("Printing...");
}
