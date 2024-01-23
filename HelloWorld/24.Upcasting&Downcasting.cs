using System;
public class UpAndDownCasting
{
    public static void EntryPoint()
    {
        /* Upcasting and Downcasting */
        // Upcasting
        Vehicle mercedes = new Car("SDFOIJ"); // Upcasting: Creating an instance of a child class with a parent type. This can be done implecitly
        mercedes.Move();

        // Downcasting
        Car benz = (Car)new Vehicle("SOIDFJ"); // Downcasting: Creating a parent or base class, and casting it to a child type. This has be be explicitly specified.
                                               // OR
        Vehicle vehicle = new Vehicle("DOIJFSD");
        Car toyota = (Car)vehicle;
        // OR
        if (vehicle is Car)
        {
            // The perform the downcasting
            Car car2 = (Car)vehicle;
        }
        // OR
        Car vehicle2 = vehicle as Car;
        if (vehicle2 != null)
        {
            // Perform operation here
        }
    }
}