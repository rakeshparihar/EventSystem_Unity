# EventSystem_Unity

Delegate:
A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime.

Delegates are especially used for implementing events and the call-back methods. All delegates are implicitly derived from the System.Delegate class.

Declaring Delegates
Delegate declaration determines the methods that can be referenced by the delegate. A delegate can refer to a method, which has the same signature as that of the delegate.

For example, consider a delegate:

public delegate int MyDelegate (string s);
The preceding delegate can be used to reference any method that has a single string parameter and returns an int type variable.

Syntax for delegate declaration is:

delegate <return type> <delegate-name> <parameter list>

Instantiating Delegates:

Once a delegate type is declared, a delegate object must be created with the new keyword and be associated with a particular method. When creating a delegate, the argument passed to the new expression is written similar to a method call, but without the arguments to the method. For example:

public delegate void Print(string s);
...
Print ps1 = new Print(WriteToScreen);
Print ps2 = new Print(WriteToFile);

Events :
Events are user actions such as key press, clicks, mouse movements, etc., or some occurrence such as system generated notifications. Applications need to respond to events when they occur. For example, interrupts. Events are used for inter-process communication.

Using Delegates with Events
The events are declared and raised in a class and associated with the event handlers using delegates within the same class or some other class. The class containing the event is used to publish the event. This is called the publisher class. Some other class that accepts this event is called the subscriber class. Events use the publisher-subscriber model.

A publisher is an object that contains the definition of the event and the delegate. The event-delegate association is also defined in this object. A publisher class object invokes the event and it is notified to other objects.

A subscriber is an object that accepts the event and provides an event handler. The delegate in the publisher class invokes the method (event handler) of the subscriber class.

Declaring Events:

To declare an event inside a class, first a delegate type for the event must be declared. For example,

public delegate string MyDel(string str);
Next, the event itself is declared, using the event keyword:

event MyDel MyEvent;
The preceding code defines a delegate named BoilerLogHandler and an event named BoilerEventLog, which invokes the delegate when it is raised.
