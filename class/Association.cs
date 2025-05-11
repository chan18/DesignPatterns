/*
📌 Definition:
Association represents a "has-a" or "uses-a" relationship. One class contains a reference to another. It's the most generic relationship.

🧠 Purpose:
Link objects

Represent usage between classes

🎯 Real-World Analogy:
A Company has a Person as its CEO, but they exist independently

*/

public class Person
{
    public string Name { get; set; }
}

public class Company
{
    public Person CEO { get; set; }  // Association
}
