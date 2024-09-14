# Behavioral Design Pattern
 ## Strategy Pattern
  
  <Details>

  A strategy Design Pattern is a behavioral design pattern that allows you to dynamically change the behavior of an object by encapsulating it into different strategies.

  This pattern enables an object to choose from multiple algorithms and behaviors at runtime, rather than statically choosing a single one.

  In simpler words, the Strategy Design Pattern provides a way to extract the behavior of an object into separate classes that can be swapped in and out at runtime.
  This enables the object to be more flexible and reusable, as different strategies can be easily added or modified in the future based on the requirement
  without changing the object's core code.

  ### Examples
  
  1. *Route planning* - Fastest route between source and destination in a particular location and here strategies can be defined by Car, by Bike, by Bus, by walking (which is faster in a city like Bangalore: joy:)
  2. *Sorting Algorithm* - Different sorting algorithms can be encapsulated into separate strategies and passed to an object that needs sorting.
  3. *Text formatting* - Different formatting strategies can be encapsulated into separate strategies and passed to an object that needs formatting.
  4. *Database access* - Different database access strategies can be encapsulated into separate strategies and passed to an object needing data from different sources.
  5. *Payment strategy* - Different payment methods can be encapsulated into separate strategies and passed to an object that needs to process payments.
  
  ### Componenents

  1. **Context** -  Object will delegate its behavior to the strategies. It will maintain a reference to strategy object.
  2. **Strategy Interface** - Define the behavior for all strategies.
  3. **Concrete Strategies** - Implement the Strategy interface. Each strategy encapsulates a specific behavior.

  </Details>

## Observer Pattern

  <Details>

  It is a design pattern that allows you to define a subscription mechanism to notify mutiple objects(subscribers)  about the event that are happening to the object they have subscribed.

  It defines a one-to-many dependency between objects so that when one object (the subject) changes state, all its dependents (observers) are notified and updated automatically.
  It primarily deals with the interaction and communication between objects, specifically focusing on how objects behave in response to changes in the state of other objects.

  ### Example
  
  1. Weather station is observed by various smart devices. The weather station maintains a list of registered devices. When there’s a change in weather conditions, the weather station notifies all devices about the update.
  2. Iphone product store is observed by a lot of people. Store maintains the list who wants to be notified , whenenever the product is availanle, its notifies all the person who have subscribed.

  ### use Case

  1. Use the Observer pattern when changes to the state of one object may require changing other objects, and the actual set of objects is unknown beforehand or changes dynamically.
  2. Use the pattern when some objects in your app must observe others, but only for a limited time or in specific cases.

  </Details>

## Mediator Pattern 

Ex- Online Auction System, Airline Management System(Two planes never interact with each other rather talk with a mediator like airline management system to seek their permission whether they can land or not)

It encourage loose coupling by keeping objects from referring to each other explicitly and allows them to communicate through a mediator object.
It reduced chaotic dependencies between objects. The pattern restricts direct communications between the objects 
and forces them to collaborate only via a mediator object.





