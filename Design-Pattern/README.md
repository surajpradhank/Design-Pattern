# Behavioral Design Pattern
 ## Stratergy Pattern
  
  <Details>

  A strategy Design Pattern is a behavioral design pattern that allows you to dynamically change the behavior of an object by encapsulating it into different strategies.

  This pattern enables an object to choose from multiple algorithms and behaviors at runtime, rather than statically choosing a single one.

  In simpler words, the Strategy Design Pattern provides a way to extract the behavior of an object into separate classes that can be swapped in and out at runtime.
  This enables the object to be more flexible and reusable, as different strategies can be easily added or modified in the future based on the requirement
  without changing the object's core code.

  ### Use Case
  
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

# Creational Design Pattern
  ## Factory Pattern

