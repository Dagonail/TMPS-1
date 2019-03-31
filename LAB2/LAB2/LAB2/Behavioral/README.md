# Laboratory Nr.3

## Task
Implement 5 behavioral patterns

*NOTE: This program was developed implementing 5 patterns each time, and each time from different category. Please, don't jugde the logic of the project. Main purpose was to study the patterns. Is hard to link them or to create a logic in this kind of development*

## What was implemented?
1. Chain of Responsability
2. Command
3. Iterator
4. Observer
5. Strategy


**Chain of responsability** you can find [here](https://github.com/Secoranda/TMPS/blob/master/LAB2/LAB2/LAB2/Behavioral/ChainofRes.cs)
Per theory: *The chain of responsibility pattern allows you to pass a request to from an object to the next until the request is fulfilled.*

In our case we have a class Worker and a class Manager. To change roles between them, there is a boolean variable.
For false, will be Manager, for true - Worker. We'll consider the situation when a made order, should be cancelled. In case it can be change, the action is done by Worker, if needs to be cancelled, it will switch to Manager.

![image](https://user-images.githubusercontent.com/24621285/55294660-54787800-540d-11e9-8a55-54ac5c0df416.png)

**Command** is [here](https://github.com/Secoranda/TMPS/blob/master/LAB2/LAB2/LAB2/Behavioral/Command.cs)
The command design pattern allows you to store a list of actions that you can execute later. A common example is storing the undo actions in an application.
So in our case, we'll consider a possible cancel or change after order is done. It stores the Menus.

**Iterator** is [here](https://github.com/Secoranda/TMPS/blob/master/LAB2/LAB2/LAB2/Behavioral/Iterator.cs)
Theory: *The Iterator Design Pattern allows you abstract out the details of traversing collections. For example, you may different types of collections in your applications, such as an array, a linked list, or a generic dictionary. For whichever the types of collections you have, you will need to traverse, or iterate through the items in the collections. *

**IIterator**  interface defines all the methods needed to traverse the collection.
The **IAggregate** interface defines the methods for the client. The methods that it defines allows the client code not to be bothered with the details on how the collection is traversed. It has the GetAll method that the client can call. Same we'll store in collection menus.
See it [here](https://github.com/Secoranda/TMPS/blob/master/LAB2/LAB2/LAB2/Behavioral/Iterator.cs)

**Observer** - [click](https://github.com/Secoranda/TMPS/blob/master/LAB2/LAB2/LAB2/Behavioral/Observer.cs)
Theory: *	
The Observer Design Pattern allows you to have a publisher-subscriber framework where a change to a publisher will notify all of its subscribers automatically. *
Let's imagine, that a Menu changed. It can be deleted or combined to other Menus.
Our Observer will allow to have a update product framework, where a Menu can be changed to another one. It can be in Main Menus or per order.

**Strategy** - *The Strategy Design Pattern allows you to change the behavior of an application when given a context.*
Talking about order, we can have order per phone, parking (with car), per person in the restaurant. The benefit of the strategy pattesn is it allows user to choose the behvior of the application at runtime, in our case, order mode. See [here](https://github.com/Secoranda/TMPS/blob/master/LAB2/LAB2/LAB2/Behavioral/Strategy.cs)

![image](https://user-images.githubusercontent.com/24621285/55294664-665a1b00-540d-11e9-80fe-266f3438d612.png)
