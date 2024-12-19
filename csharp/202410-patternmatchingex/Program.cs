using Calculators;
using CommercialRegistration;
using LiveryRegistration;
using ConsumerVehicleRegistration;

// Placeholder objects
var car = new Car() { Passengers = 3 };
var deliveryTruck = new DeliveryTruck();
var taxi = new Taxi() { Fares = 0 };
var bus = new Bus() { Capacity = 40, Passengers = 3};
var tollCalculator = new TollCalculator();

Console.WriteLine($"Toll for car is {tollCalculator.CalculateToll(car)}");
Console.WriteLine($"Toll for taxi is {tollCalculator.CalculateToll(taxi)}");
Console.WriteLine($"Toll for bus is {tollCalculator.CalculateToll(bus)}");
Console.WriteLine($"Toll for deliveryTruck is {tollCalculator.CalculateToll(deliveryTruck)}");
