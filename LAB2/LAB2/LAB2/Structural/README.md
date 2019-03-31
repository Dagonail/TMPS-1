# Laboratory Nr. 2
## Task
Implement 5 structural patterns.

NOTE: Was late with deadline and want to use my point for that.

## What was done?

1. **Bridge** pattern

What does bridge? *Decouple an abstraction from its implementation so that the two can vary
independently.* 

This was implemented in creating the Client class. This class is a bridge between the implementation and the abstract class.
Later on, in implementation it uses Adapter pattern, Decorator patter, Farcade pattern and Proxy inside.


2. **Adapter** pattern

Adapter? *	
The Adapter Design Pattern allows you to make an existing class work with other existing class libraries without changing the code of the existing class.*

We'd suppose that we can have Clients as Adults and Kids. So it can be Adults independently or Adults with Kids.
So, there is an adapter between Clients and Adults, and Adults and Kids.

3. **Proxy** pattern

Proxy? *Provide a surrogate or placeholder for another object to control access to it.*
In our case, was implemented 2 Proxy classes(**ProxyOrderGender** and **ProxyOrder**), one checks the availability of toys per gender for HappyMeal, other one
checks if the chosen meal is available or client should wait the kitchen.

![hop](https://user-images.githubusercontent.com/24621285/55293853-a7e5c880-5403-11e9-8a68-d99f31ed8df9.PNG)

4. **Decorator** pattern

Decorator: *Attach additional responsibilities to an object dynamically. Decorators provide

![order](https://user-images.githubusercontent.com/24621285/55293854-a7e5c880-5403-11e9-923b-aa452e8df81d.PNG)
a flexible alternative to subclassing for extending functionality.*
Was implemented class **AdultClientDecor**.
Our decorator will advice if the new client has disabilities or not. In order to that it can be served first.

5. **Farcade** pattern

Farcade: *The façade design pattern allows you to provide a simplified interface from multiple class libraries. It provides a simple interface that hides the complexity of the class libraries being used. *

Same, were implemented 2 classes for Farcade(**FarcadeToy** and **FarcadeOrder**), and both of them hide the complexity of Proxy pattern classes.
So they wrap all the complexity od Proxy patterns.

![farcade2](https://user-images.githubusercontent.com/24621285/55293852-a7e5c880-5403-11e9-81ff-445e58d938b6.PNG)



See [MAIN](https://github.com/Secoranda/TMPS/blob/master/LAB2/LAB2/LAB2/Program.cs)
