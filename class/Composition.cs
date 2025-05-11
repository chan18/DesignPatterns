/*
📌 Definition:
Composition is a strong type of association where the part cannot exist without the whole. The containing class owns the lifetime of the part.

🧠 Purpose:
Enforce strong ownership

Automatically manage component lifetime

🎯 Real-World Analogy:
An Engine cannot function outside of a Car. Destroying the car destroys the engine.
*/

public class Engine
{
    public void Start() => Console.WriteLine("Engine started.");
}

public class Car
{
    private Engine engine = new Engine(); // Composition

    public void StartCar() => engine.Start();
}
