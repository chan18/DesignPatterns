loosely copuled OOP design.


new is copuling


we should not program to implemenation.

new = concrete.


`

    tying code with concrete class makes it more fragile and less flexible.

`


Duck duck = new MallarDuck();



when we have lot of concrete classes we need to use cases, if-else.

decision of which to instantiate is made at runtime depending on some set of conditions.


it will result in re-writing or changes in this code. it is not maintenable.


How might you take all the parts of your application that instatntiate concrete classes and separate or encapsulate them from the reset of 
your applciation? 




hwo do we encapsualte object creation?



SimplePizzFactory



simple factory isn't actually design pattern.

it's more of a programming idiom.



Reminder : 

In design pattern the phrase

"implement to interface" does not always mean.

" write a class that implements a java interface"

In general

a concrete class implementing a method from a supertype.




framework idea

create a framework that ties the store and the pizza creation together.


yet allow things remain flexible.



let the subclasses decide.































