/*
    allws you to define a skelton of an algorithm in a base calass and let subclass override the steps without chaning th eoverall algorithms structure

    identification 

    see a method in a base class that calls a bunch of other methods that are either abstract or emepty
*/



/*

    The abstract class defines a tempalte method that contains the skelton of the algorithm. 

    composeed of calls to abstract primitive operations.

    concrete subclass should implement this operations, but leave the tempalte method itself intact.

*/
abstract class AbstractClass
{

    // the tempalte method defins the skelton of an algorithm.
    public void TemplateMethod()
    {
        this.BaseOperation1();
        this.RequiredOperation1();

        this.BaseOperatoin2();

        this.Hook1();

        this.BaseOperatoin2();
        this.RequiredOperation2();
        
        this.Hook2();
    }


    // these opeartions already have implementations.
    protected void BaseOperation1()
    {
        Console.WriteLine("");
    }

    protected void BaseOperatoin2()
    {
        Console.WriteLine("");
    }

    protected void BaseOperation3()
    {
        Console.WriteLine("");
    }

    // these operations have to be implemented in subclasses.
    protected abstract void RequiredOperation1();

    protected abstract void RequiredOperation2();

    /*
        These are "hooks," subclasses may override them, but it's not madatory since the hooks already have default ( but emtpy ) implemtnation. 

        hooks provide additional extension points in some crucial places of the algorithm.
    */
    protected virtual void Hook1() { }

    protected virtual void Hook2() { }
}

/*

    Concreate classes have to implement all abstract operations of the base class.

    they can also override some opeartions with a default implemetnaiton.
*/
class ConcreateClass1 : AbstractClass
{
    protected override void RequiredOperations1()
    {
        //
    }

    protected override void RequriedOperations2()
    {
        //
    }
}

class ConcreateClass2 : AbstractClass
{
    protected override void RequiredOperations1()
    {
        //
    }

    protected override void RequriedOperations2()
    {
        //
    }

     protected override void Hook1() 
     { 
        //
     }
}


class Client
{
    /*

        the client code calls the tempalte method to execute the algorithm. 

        client code does not have to know the concrete class of an object it work with

        as long as it works with objects through the itnerface of there base class.

    */
    public static void ClientCode(AbstractClass abstractClass)
    {
        abstractClass.TemplateMethod();
    }
}

class Program
{
    static void Main(string[] string)
    {        
        Client.ClientCode(new ConcreateClass());

        Client.ClientCode(new concreateClass2();
    }
}
