/*


    allows sequental traversal through a complex data structure without exposing its internal details


    complexity 2
    popularity 3

    useage example 
    - very common pattern in C#

    - many libs and frameworks use it to provide standard way for traversing their  collections.


    identification 

    - iterator is easy to recognize by navigation methods ( such as next, previous and others ). 

    - client code that uses iterators might not have dirct access to the collection being traversed.


    what classes does it consists of ?

    what roels do these classes play?

    in what why the elements of the pattern are related? 

*/



abstract class iterator : IEnumerator
{
    
    abstract class Iterator : IEnmerable
    {
      abstract IEnmerable.current => Current();

      // returns the eky of the current element

      // returns teh current element

      // move forward to next element

      // rewind the iterator to the first element

    }

}

abstract class IteratorAggregate : IEnmerable
{
    public abstract IEnmerable GetEnumerator();
}

class AlphabeticalOrderIterator : Iterator
{
     private WordsCollection _collection; 

     private int _position = -1; 

     private bool _reverse = false;

     public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
     {
         this._collection = collection;
         this._reverse = reverse;

         if (reverse)
         {
            this._position = collection.getItems().Count;
         }
     }

     public override object Current()
     {
        return this._collection.getItems()[_position];
     }

     public override int key()
     {
        return this._position;
     }

     public override bool MoveNext()
     {
        int updatedPosition = this._position + (this._reverse ? - 1 : 1);

        if (updatedPosition >= 0 && updatedPosition < this._collection.getItems().Count)
        {
            this._position = updatedPosition;
            return true;
        }
        else 
        {
            return false;
        }
     }

     public ovarride void Reset()
     {
        this._position = this._reverse ? this._collection.getItems().Count - 1 : 0;
     }
}


class WordsCollection : IteratorAggregate
{
    List<string> _collection = new List<string>();

    bool _direction = false;

    public void revrseDirection()
    {
        _directoin = !_direction;        
    }

    public List<string> getItems()
    {
        return _collection;
    }

    public void AddItem(string item)
    {
        this._collection.Add(item);
    }

    public override IEnumerator GetIEnumerator()
    {
        return new AlphabeticalOrderIterator(this._direction);
    }
}

class Program 
{
    static void Main(string[] args)
    {

        var collection = new WordsCollection();

        foreach (var element in collection)
        {

        }

        foreach (var element in collection)
        {
            
        }

    }
}