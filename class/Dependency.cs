/*

📌 Definition:
A "uses" relationship where one class depends on another to perform a task, usually by passing it as a method parameter or injecting it.

🧠 Purpose:
Decoupling

Better testing (e.g., mocking)

Flexibility

🎯 Real-World Analogy:
A Service uses a Logger temporarily during a task, but doesn’t own or control it.

*/

public class Logger
{
    public void Log(string msg) => Console.WriteLine(msg);
}

public class Service
{
    public void Process(Logger logger)
    {
        logger.Log("Process started.");
    }
}
