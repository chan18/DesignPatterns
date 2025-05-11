
// visitor pattern

/*

    adding new behaviors to existing class hierarchy without altering any existing code.



    visitors

    Client.Component.Accept(Components, vistiros)

*/


/*
    The component interface declares an 'accept' method that should take the
    base visitor interface as an argument.
*/
public interface IComponent
{
    void Accept(Ivisitor visitor);
}


/*
    each concreate component must implement the Accept method in such a way that it calls the visitor's method correspondign to the component's class
*/
public class ConcreateComponentA : IComponent
{
    /*
        Note that we're calling 'VisitorConcreateComponentA', Which matches the current class name.
        This way we let the visitor know the class of the component it works with.
    */
    pubilc void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponentA(this);
    }

    /*

        Concreate Components may have speical methods that don't exist in there base or interface.

        the visitor is still able to use these methods since it's aware of the component's concrete class.

    */
    public string ExclusiveMethodOfConcreateComponentA()
    {
        return 'A';
    }
}


public class ConcreateComponentB : IComponent
{
    pubilc void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponentA(this);
    }

    public string ExclusiveMethodOfConcreateComponentB()
    {
        return 'B';
    }
}


public interface IVisitor 
{
    void VisitorConcreteComponentA(ConcreateComponentA element);
    void VisitorConcreteComponentB(ConcreateComponentB element);
}



/*

    concreate visitors implement serveral versions of the same algorithm, which can work with all concreate component class.

    you can experience the biggest benefit of the visitor pattern when using it with a complex object structure, such as a composite tree. 

    in  this case, it might be helpful to store some intermediate state of the algorithm while excuting visitor's methods over viraous objects of the structure.

*/
class ConcreteVisitor1 : IVisitor
{
    public void VisitConcreteComponentA(ConcreteComponentA element)
    {
        Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor1");
    }

    public void VisitConcreteComponentB(ConcreteComponentB element)
    {
        Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor1");
    }
}


class ConcreteVisitor2 : IVisitor
{

    public void VisitConcreteComponentA(ConcreteComponentA element)
    {
        Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor1");
    }

    public void VisitConcreteComponentB(ConcreteComponentB element)
    {
        Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor1");
    }
}


public class Client
{

    /*

       the client code can run visitor operations over any set of elements without figuring out there concrete classes. 

       the accept oepration directs a call to the appropriate operation in the visitor object.

    */

    public static void ClientCode(List<IComponent> components, IVisitor visitor)
    {
        foreach (IComponent component in components)
        {
            component.Accept(visitor);
        }
    }

}


class Program
{
    static void Main(string[] args) 
    {
        // init list of components 
        List<IComponent> component = new List<IComponent>()
        {
            new ConcreteComponnetA(),
            new ConcreteComponnetB()
        }

        // concrete visitor
        var visitor1 = new ConcreteVisitor1();
        // add components and visitor
        Client.ClientCode(component, visitor1);

        // create visitor 2 
        var visitor1 = new ConcreteVisitor2();
        // add components visitor
        Client.ClientCode(component, visitor2);   
    }
}
