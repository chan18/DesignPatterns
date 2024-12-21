# The Observer pattern.

Requirements

Our Goal


Stretch Goal

constant in software development.
change

* Expandability.


question - 
A
B
C
E

OBSERVER PATTERN

news paper `example`

publishers + subscribers = observer pattern

publisher the SUBJECT

subscribers the OBSERVERS

subject object that manage some important data.

when the data in the subject is chagned,
the observers are notified.

The Observer Pattern
- defines a one-to-many dependency between objects so that when one object changes state.
- all of its dependents are notified and updated automatically.

one-to-many relationship

The observer pattern defines a one-to-many relationsip between a set of objects.

when the state of one object chagnes, all of it's dependencts are notified.


We have one subject, notifies many observers.
the observers dependent on the subject.


most revovle around a class design that includes Subject and Observer interfaces.


```mermaid
classDiagram

    note for Observer "All potential observers need to implement the observer interface. update() called when subject state change"

    class Observer {
        <<interface>>
        +Update()
    }

    class ConcreteObserver {
        update()
    }

    note for Subject "Object use this interface to register as observers and also for removing them self"

    class Subject {
        <<interface>>
        +registerObserver()
        +removeObserver()
        +notifyObservers()
    }


    class ConcreteSubject {
        +registerObserver()
        +removeObserver()
        +notifyObservers()
    }    

    Subject --|> Observer : each subject can ahve many observers.

    ConcreteSubject ..|> Subject

    ConcreteObserver --|> ConcreteSubject : 
    ConcreteObserver ..|> Observer


```

Loose copuling


when two objects are lossely copuled, 
They can interact,
but they typically have very little knowledge of each other. 


Loosely copuled designs often give us a lot of flexibility


Observer pattern is a greate example of loose copuling. 


Design Principle - 4

`
    Strive for lossely coupled designs between objects that interact
`

loosely coupled desgins allow us to build flexible OO systems

that can handle change because they minimize the interdependency between objects.


```mermaid
classDiagram 

    class IObserver {
        <<interface>>
        +Update()
    }

    class IDisplayElement {
        <<inteface>>
        +Display()
    }

    class ISubject {
        <<interface>>
        +RegisterObserver()
        +RemoveObserver()
        +NotiyObservers()
    }

    class WeatherData {
        +observer : List<IObserver>
        +Temperature : float
        +Humidity : float
        +BarometricPressure : int

        +RegisterObserver()
        +RemoveObserver()
        +NotiyObservers()

        +GetObserver()
        +SetObserver()
    }

    class CurrentConditionasDisplay  {
        +Update()
        +Display()
    }

    class StatisticsDisplay  {
        +Update()
        +Display()
    }

    class ThirdPartyDisplay  {
        +Update()
        +Display()
    }

    class ForecastDisplay  {
        +Update()
        +Display()
    }


    WeatherData ..|> ISubject

    CurrentConditionasDisplay ..|> IDisplayElement
    
    CurrentConditionasDisplay ..|> IObserver

    StatisticsDisplay ..|> IDisplayElement
    StatisticsDisplay ..|> IObserver

    ThirdPartyDisplay ..|> IDisplayElement
    ThirdPartyDisplay ..|> IObserver

    ForecastDisplay ..|> IDisplayElement
    ForecastDisplay ..|> IObserver
```


```c#

    public interface Subject {
        public void RegisterObserver(Observer o);
        public void RemoveObserver(Observer o);
        public void NotifyObserver(Observer o);
    }


    public interface Observer {
        public void update();
    }


    public interface DisplayElement {
        public void display();
    }

    public class WeatherData : ISubject  {
            private List<IObserver> observers;
            private float temparature;
            private float pressure;

            public WeatherData() {
                observers = new();
            }

            public void RegisterObserver(Observer o) {
                observers.Add(o);
            }


            public void RemoveObserver(Observer o) {
                observers.Remove(o);
            }

            public void NotifyObservers() {
                foreach(var observer in observers) {
                    observer.Update();
                }
            }

            public void MeasurementsChanged() {
                this.NotifyObservers();
            }

            public void setMeasurements(float temparature, float humidty, float pressure) {
                this.temparature = temparature;
                this.humidty = humidty;
                this.pressure = pressure;
                MeasurementsChagned();
            }
    }

    

    public class CurrentConditionsDisplay : IObserver, IDisplayElement  {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData) {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            this.temparature = weatherData.GetTemperature();
            this.humidty = weatherData.GetHumidity();
            this.Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and "  + humidty +  "% humidyt");
        }
    }


    public class WeatherStation {
        public static void main(string[] args) {
            WeatherData weatherData = new();

            CurrentConditionsDisplay currentDisplay = new(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
        }
    }
```



Design Principle Challenge


Identify the aspects of your application that vary 
and separate them from what stays the same.

Abstarction? Encapsualtion?

-  we get new displays 


Program to an interface, not an implementation
- program to supertype
- IObservers types.


Favor composition over inheritance
 - Subject is coposed of many observers.


