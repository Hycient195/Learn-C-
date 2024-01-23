using System;
public class Animal
{
    public string Name;
    public byte Age;
    public List<Person> Researchers;

    /* A constructor is a method executed when the instance of a class is created.
     * It is mostly used for initializaing class fields and setting default values
       Think of a constructor as the place you would want to put any piece of code
       That would execute once an instance of a class is created.

        Unlike other methods, a constructor does not have a return type and cannot
        be static.
     */


    // Parameterless Constructor
    public Animal()
    {
        // It is necessary to initialize any list or array type property in the constructor
        // in order to avoid Null Referemce Exception Error
        this.Researchers = new List<Person>();
    }

    // Constructor overload
    public Animal(string name)
        : this() // This is called constructor chaining. This calls the constructor variant with the input signature
                // similar to that of  the "this()" function, first before calling this constructor, when this
                // constructor overload is being used.
    {
        this.Name = name;
    }

    public Animal(string name, byte age)
        : this(name)
    {
        this.Age = age;
    }

    public Animal(string name, byte age, Person researcher)
        : this(name, age)
    {
        this.Researchers.Add(researcher);
    }
}

/* It is good to note that the use of constructor chaining should be reduced to the barest
   minimum and only used when necessary, like in the initializatin of lists. The reason
   for this is to minimize clutter in the chaining of one constructor to another */