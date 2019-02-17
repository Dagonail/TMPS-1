# Laboratoy Work Nr.1

## Task?
Study and implement 5 creational patterns on your choice.

## What was implemented?
1. Singleton
2. Prototype;
3. Builder with ConcreteBuilder;
4. Factory;
5. AbstractFactory.

## Program subject?
Food - meals, drinks and menus.
> Note: Don't judge subject implementation. Purpose of the laboratory was to understand crational patterns

## What and where?
 
**Singleton** is linked with **AbstractFactory** through 
**[Option](https://github.com/Secoranda/TMPS/blob/master/LAB1/LAB1/LAB1/Option.cs)**
class which gives one option at a time.
As per theory: *exactly one instance of a class and is accessible to clients from a well-know access point.*
So it creates its own unique instance which represents client choice from meal, drink and menu.
  
  This choice is **[ChosenOption](https://github.com/Secoranda/TMPS/blob/master/LAB1/LAB1/LAB1/ChosenOption.cs) class** which represents the **Abstract Factory**. It creates the link to
  **MealFactory**.
  **DrinkFactory** and **MenuFactory** through interfaces.
  . In theory words: *provides an interface for creating families or related
  or dependent object without specifying their concrete classes.*

Next we have **Factory** pattern with 3 factories.
 1. **[MealFactory](https://github.com/Secoranda/TMPS/blob/master/LAB1/LAB1/LAB1/MealFactory.cs)** and
 **[DrinkFactory](https://github.com/Secoranda/TMPS/blob/master/LAB1/LAB1/LAB1/DrinkFactory.cs)** 
 classes uses an inteface and a switch statement with a paramenter from **Builder classes**.
 In such a way, are linked **Factory** and **Builder** pattern.
 
    -To make a parallel: 
 *Factory - Define an interface for creating an object.
 Builder - separates the construction of a complex object from its representation so that
the same construction process can create different representations.*
 
       1.1. **Builder** pattern was used to create **[Meal](https://github.com/Secoranda/TMPS/blob/master/LAB1/LAB1/LAB1/Meal.cs)**, 
       **[Drink](https://github.com/Secoranda/TMPS/blob/master/LAB1/LAB1/LAB1/Drink.cs)** classes. **Builder** is more like an interface,
 product itself is created by  **ConcreteBuilder**. Typically is needed a **Director class**, but taking in consideration 
 that laboratory is intrudoctive and Meal/Drink classes are separate ones, we will avoid it for this time.
 
 2. **[MenuFactory](https://github.com/Secoranda/TMPS/blob/master/LAB1/LAB1/LAB1/MenuFactory.cs)** is linked with **Prototype class**. Menu is a combination between Meal and Drink. So to avoid creation
 of the same objects is used *clone()* method throough Prototype pattern. So we have, **Menu class**
    - Theory: *Prototype - Specifies the kinds of objects to create using a prototypical instance, and create
new objects by copying this prototype*
      
      2.1. **[Menu](https://github.com/Secoranda/TMPS/blob/master/LAB1/LAB1/LAB1/Menu.cs) class** returns a clone of a meal and a drink implemented previously.
      
After running main **[Program](https://github.com/Secoranda/TMPS/blob/master/LAB1/LAB1/LAB1/Program.cs)**
on the screen is obtained an output. See [screenshots](https://github.com/Secoranda/TMPS/tree/master/LAB1/Screens)

In order to do this laboratory was used mainly:
1. Site: *www.codeproject.com;*
2. Book: *Design Patterns :Elements of Reusable Object-Oriented Software,Produced by KevinZhang*
