using System;
using System.Collections.Generic;

#region Inheritance Example

// Base class representing a generic Animal
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Derived class - Dog inherits from Animal
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

#endregion

#region Association Example

// A simple Person class
public class Person
{
    public string Name { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name}.");
    }
}

// Company has a Person as its CEO - this is an association
public class Company
{
    public Person CEO { get; set; }

    public void ShowCEO()
    {
        Console.WriteLine("Company's CEO:");
        CEO.Introduce();
    }
}

#endregion

#region Aggregation Example

// Departments can exist independently of a University
public class Department
{
    public string DepartmentName { get; set; }

    public void PrintDepartment()
    {
        Console.WriteLine($"Department: {DepartmentName}");
    }
}

// University aggregates Departments
public class University
{
    public List<Department> Departments { get; set; }

    public University()
    {
        Departments = new List<Department>();
    }

    public void ListDepartments()
    {
        Console.WriteLine("University has the following departments:");
        foreach (var dept in Departments)
        {
            dept.PrintDepartment();
        }
    }
}

#endregion

#region Composition Example

// Engine class used inside Car
public class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started.");
    }
}

// Car composes Engine - it creates and owns it
public class Car
{
    private Engine engine = new Engine(); // composition

    public void StartCar()
    {
        engine.Start();
        Console.WriteLine("Car is running.");
    }
}

#endregion

#region Dependency Example

// Logger class used by other services
public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}

// Service depends on Logger but doesn't own it
public class Service
{
    public void Process(Logger logger)
    {
        logger.Log("Service processing started.");
        Console.WriteLine("Service is doing some work...");
        logger.Log("Service processing completed.");
    }
}

#endregion

#region Program Entry Point

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== INHERITANCE ===");
        Dog dog = new Dog();
        dog.Eat(); // inherited from Animal
        dog.Bark(); // defined in Dog

        Console.WriteLine("\n=== ASSOCIATION ===");
        Person ceo = new Person { Name = "Alice Smith" };
        Company company = new Company { CEO = ceo };
        company.ShowCEO(); // uses associated Person

        Console.WriteLine("\n=== AGGREGATION ===");
        Department csDept = new Department { DepartmentName = "Computer Science" };
        Department mathDept = new Department { DepartmentName = "Mathematics" };
        University university = new University();
        university.Departments.Add(csDept);
        university.Departments.Add(mathDept);
        university.ListDepartments(); // uses aggregated departments

        Console.WriteLine("\n=== COMPOSITION ===");
        Car myCar = new Car();
        myCar.StartCar(); // composed Engine

        Console.WriteLine("\n=== DEPENDENCY ===");
        Logger logger = new Logger();
        Service service = new Service();
        service.Process(logger); // dependency injection via parameter
    }
}

#endregion
