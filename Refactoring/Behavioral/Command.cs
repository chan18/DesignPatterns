
/*

 That converts requests or simple operations into objects

    complexity 1 star
    
    popularity 3 star

 usage eample 

 command pattern is pretty common in C# code. 
 
 most often it's used as an alternative for callbacks to parameterizing UI elemnts with actions. It's also used for queueing tasks, tracking operations history, etc..

 identification

 Recognizalbe by behavioral methods in an abstract/interafce type (sender) which invokes a method in an implemenation of a different abstract/interface type (receiver) which has been encapsulated by the command implementation during its creation

 command class are usally limited to speicif action.


focuses on answering 

what classes does it consist of?

what role do these classes play?

in what way the elments of the pattern are related?

*/


namespace RefactoringGuru;


// the command interface declares a  method for excuting a command.
public interface ICommand 
{
    void Execute();
}


// Some commands can implement simple operations on there own.
class SimpleCommand : ICommand
{

    public void Execute()
    {
        // do some excution
    }
}


/*
    however, some commands can delegeate more complex operations to other objects called recivers.
*/

class ComplexCommand : ICommand
{

    private Receiver _receiver;

    // context data, requried fro launching the recivers method.
    private string _a;

    private string _b;


    /*  
        complex command can accept one or several reciver objects along
        with any context data via the consturctor.
    */
    public ComplexCommand(Receiver receiver, string a, string b)
    {
        this._receivers = receiver;
        this._a = a;
        this._b = b;
    }

    public void Execute()
    {
        // do soem execution
        this._receiver.DoSomething(this._a);
        this._receiver.DoSomethingElse(this._b);
    }

}


/*


*/
public void DoSomethingImportant()
{

}

/*



*/
class Receiver
{

}

/*
    The invoker is associated with one or several commands. It sends a request to the command.
*/
class Invoker
{

}



class program
{
    static void Main(string[] args)
    {
        // setup.

        // create invoker
        Invoker invoker = new Invoker();

        // set on start simple command
        invoker.SetOnStart(new SimpleCommand("Say HI!"));

        // another receiver
        Receiver receiver = new Receiver();

        // set on finish a complex command
        invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

        // do something important.
        invoker.DoSomethingImportant();
    }
}

