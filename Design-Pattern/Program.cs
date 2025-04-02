// See https://aka.ms/new-console-template for more information
using Design_Pattern.BehavioralCall;
using DesignService.Behavioral.MediatorPattern.Colleague;
using DesignService.Behavioral.MediatorPattern.Mediator;
using DesignService.Creational.FactoryPattern;
using DesignService.Structural.AdapterPattern;
using DesignService.Structural.DecoratorPattern;

Console.WriteLine("Hello, World! Explore Design pattern used in software development");

#region Call Strategy Design Pattern
//Console.WriteLine("Strategy design pattern example");
StrategyStore.validateStrategy();
#endregion

#region Call Observer Design Pattern
//Console.WriteLine("Observer Design Pattern Example");
//ObserverStore.ValidateObserver();
#endregion

#region Call Mediator Design Pattern
//Console.WriteLine("Mediator Design Pattern Example");
//IAuctionMediator auctionMediator = new Auction();

//IColleague bidder1 = new Bidder("P1", auctionMediator);
//IColleague bidder2 = new Bidder("P2", auctionMediator);
//IColleague bidder3 = new Bidder("P3", auctionMediator);
//IColleague bidder4 = new Bidder("P4", auctionMediator);

//bidder1.PlaceBid(1000);
//bidder2.PlaceBid(2000);
//bidder3.PlaceBid(3000);
//bidder4.PlaceBid(3500);
//Console.WriteLine("--------------New Bid By P1------------");
//bidder1.PlaceBid(4000);

//Console.ReadLine();

#endregion

#region Call Decorator pattern

BasePizza margChesee = new ExtraCheeseDecorator(new Margherita());
Console.WriteLine("Margherita + Extra Cheese cost = " + margChesee.Cost());

BasePizza margCheseeWithMushroom = new MushroomDecorator(new ExtraCheeseDecorator(new Margherita()));
Console.WriteLine("Margherita + Extra Cheese cost = " + margChesee.Cost());

// Create a Margherita pizza
BasePizza margherita = new Margherita();

// Apply multiple decorators to the Margherita pizza
BasePizza margChesee1 = new ExtraCheeseDecorator(margherita);
BasePizza margCheseeWithMushroom1 = new MushroomDecorator(margChesee);

Console.WriteLine("Margherita + Extra Cheese + Mushroom cost = " + margCheseeWithMushroom1.Cost());
Console.WriteLine("Margherita + Extra Cheese + Mushroom cost = " + margCheseeWithMushroom.Cost());
#endregion

#region Call Factory Pattern

AnimalFactory animalFactory = new();

IAnimal dog = animalFactory.CreateAnimal("dog");
dog.Speak();

IAnimal cat = animalFactory.CreateAnimal("cat");
cat.Speak();
#endregion

#region Adapter Desing Pattern
OldSystem oldSystem = new OldSystem();
Adapter adapter = new Adapter(oldSystem);
NewSystem newSystem = new NewSystem();

// Get adapted data and pass it to the new system
string adaptedData = adapter.GetDataForNewSystem();
newSystem.DisplayData(adaptedData);
#endregion

Console.WriteLine("Thank you");


