# Behavioral Design Pattern
 ## Strategy Pattern
  
  <Details>

  A strategy Design Pattern is a behavioral design pattern that allows you to dynamically change the behavior of an object by encapsulating it into different strategies.

  This pattern enables an object to choose from multiple algorithms and behaviors at runtime, rather than statically choosing a single one.

  In simpler words, the Strategy Design Pattern provides a way to extract the behavior of an object into separate classes that can be swapped in and out at runtime.
  This enables the object to be more flexible and reusable, as different strategies can be easily added or modified in the future based on the requirement
  without changing the object's core code.

  If you want to achieve same thing using multiple ways/strategies

  ### Examples
  
  1. *Route planning* - Fastest route between source and destination in a particular location and here strategies can be defined by Car, by Bike, by Bus, by walking (which is faster in a city like Bangalore: joy:)
  2. *Sorting Algorithm* - Different sorting algorithms can be encapsulated into separate strategies and passed to an object that needs sorting.
  3. *Text formatting* - Different formatting strategies can be encapsulated into separate strategies and passed to an object that needs formatting.
  4. *Database access* - Different database access strategies can be encapsulated into separate strategies and passed to an object needing data from different sources.
  5. *Payment strategy* - Different payment methods can be encapsulated into separate strategies and passed to an object that needs to process payments.
  
  ### Components

  1. **Context** -  Object will delegate its behavior to the strategies. It will maintain a reference to strategy object.
  2. **Strategy Interface** - Define the behavior for all strategies.
  3. **Concrete Strategies** - Implement the Strategy interface. Each strategy encapsulates a specific behavior.

  </Details>

## Observer Pattern

  <Details>

  It is a design pattern that allows you to define a subscription mechanism to notify multiple objects(subscribers)  about the event that are happening to the object they have subscribed.

  It defines a one-to-many dependency between objects so that when one object (the subject) changes state, all its dependents (observers) are notified and updated automatically.
  It primarily deals with the interaction and communication between objects, specifically focusing on how objects behave in response to changes in the state of other objects.

  ### Example
  
  1. Weather station is observed by various smart devices. The weather station maintains a list of registered devices. When there’s a change in weather conditions, the weather station notifies all devices about the update.
  2. iPhone product store is observed by a lot of people. Store maintains the list who wants to be notified , when never the product is available, its notifies all the person who have subscribed.

  ### use Case

  1. Use the Observer pattern when changes to the state of one object may require changing other objects, and the actual set of objects is unknown beforehand or changes dynamically.
  2. Use the pattern when some objects in your app must observe others, but only for a limited time or in specific cases.

  </Details>

## Mediator Pattern 

  <Details>

Ex- Online Auction System, Airline Management System(Two planes never interact with each other rather talk with a mediator like airline management system to seek their permission whether they can land or not)

It encourage loose coupling by keeping objects from referring to each other explicitly and allows them to communicate through a mediator object.
It reduced chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.
	
 </Details>

# Structural  Design Pattern

## Decorator Pattern
 
<Details>

   The Decorator Pattern(Wrapper Patten) is a structural design pattern that allows you to add new functionality to an object dynamically, without modifying its original structure or class. 
   Think of it like wrapping a gift: the gift remains the same, but you can add multiple layers of wrapping paper to change how it looks or behaves.

### UseCase
   Pizza Shop - base pizza/farmhouse/VegDeligh with toppings like Extra cheese,mushroom,veggies
   Coffe - Coffe with Extra Milk,Cream
   Car - base Model with Seat Cover,power window, moon roof, AC

### Why?
 
   Class Explosion - permutation and combination of adding so many features will result in too many classes
   For this issue, we will use decorator pattern to solve class explosion

### Benefits in C#

1. Open/Closed Principle: The base class remains unchanged while decorators can add new behaviors.
2. Flexibility: Decorators can be combined in any order, allowing dynamic customization.

</Details>

## Adapter Pattern
 
<Details>

   It is a structural design pattern that allows objects with incompatible interfaces to work together. It acts as a bridge between two interfaces, converting one interface into another expected by the client.


### UseCase
 Power Plug Adapter: A common real-world analogy is a power plug adapter. 
 For example, an American plug (which is designed for 120V) may need an adapter to work with a European socket (which is designed for 230V). 
 The adapter doesn’t modify the plug or socket, but instead makes them compatible.

### Why?

### Benefits in C#

</Details>

# Creational Design Pattern

## Factory Design Pattern

<Details>

The Factory Pattern is used to create objects without directly using the new keyword or knowing the exact class to instantiate.
Instead, you use a "factory" (a class or method) to handle the creation process. This makes your code more flexible and easier to maintain.
</Details>

## Abstract Design pattern

<Details>

The Abstract Factory Design Pattern is a creational design pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes.
It is often used when you need to ensure that related objects are created together, maintaining consistency across them.


### How It Works

Abstract Factory: Declares the methods for creating abstract products.
Concrete Factories: Implement the methods to create specific product families.
Abstract Products: Define interfaces or abstract classes for a group of products.
Concrete Products: Implement the abstract product interfaces/classes.

</Dettails>








