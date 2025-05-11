/*

📌 Definition:
Inheritance models an "is-a" relationship. One class (child/derived) inherits from another class (parent/base), gaining access to its properties and methods.

🧠 Purpose:
Reuse code

Establish a hierarchy

Enable polymorphism


🎯 Real-World Analogy:
A Dog is an Animal, so it inherits common behaviors like "Eat", and adds its own like "Bark".
*/

public class Animal
{
    public void Eat() => Console.WriteLine("Eating...");
}

public class Dog : Animal
{
    public void Bark() => Console.WriteLine("Barking...");
}
