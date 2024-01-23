using System;
public class Vehicle
{
    public string Name { get; set; }
    public DateTime ProductionDate { get; set; }

    public string _registrationNumber;

    public Vehicle(string registrationNumber)
    {
        _registrationNumber = registrationNumber;
    }

    public void Move()
    {
        Console.WriteLine("Vehicle has moved");
    }
}

// The "Car" class inherits from the "Vehicle" class
// Inhertance assiciation follow a "is-a" relationship. eg. Car is a vehicle
public class Car: Vehicle
{
    /* Instead of exposing implementation details of the parent class by making the
     * registration number field to be public or protected, the derived child "Car"
     class can make an initialization call to the constructor of the "Vehicle" class
     to pass the registration number it receives to the base class constructor of the
     "Vehicle" class by calling its constructor using the "base()" function keyword.
     similar to how a constructor can call another of its overload, with "this(), it
     can also call overloads of its parent constructors using the "base()" function,
     and also pass arguments to it. */

    public Car(string registrationNumber)
        : base(registrationNumber)
    {
        // Other "Car" specific initialization can now be performed here.
    }
    public string ModelNumber { get; set; }
    public byte NumberOfWheels { get; set; }

    public void ChangeGear()
    {
        Console.WriteLine("Gear changed");
    }

    public void Drive()
    {
        Move(); // Child or derived classes can access non-private parent methods and properties
    }
}

