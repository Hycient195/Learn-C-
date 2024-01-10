// See https://aka.ms/new-console-template for more information



// Implicit Conversions

// Explicit Type  Casting


// Conversion

/* 
 * It is good to note that casting is used for the conversion of compatible types,
 * while Conversion is used conversion of uncompatible data types.
*/

public class Person
{
    public string FirstName;
    public string LastName;

    public void Greet()
    {       
        //Console.WriteLine("My name is {1} {2}", FirstName, LastName);
        Console.WriteLine("My name is " + FirstName + " " + LastName);
    }
}

