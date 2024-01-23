using System;
public class MethodModifiers
{
    public static void EntryPoint()
    {
        /* Using the "params" modifier */
        Console.WriteLine(Add(1,2,3,4,5,5));

        /* Using the "ref" modifier */
        var originalScore = 15;
        Console.WriteLine("Before reference modification: " + originalScore);
        MutateScore(ref originalScore); // The "ref" keyword is also attached to the variable when passing it to the method.
        Console.WriteLine("After reference modification: " + originalScore);

        /* Using the "out" modifier */
        int dividend = 17;
        int divisor = 6;
        int quotient;
        int remainder;

        Divide(dividend, divisor, out quotient, out remainder);
        Console.WriteLine("{0} divided by {1} is {2} remainder {3}", dividend, divisor, quotient, remainder);

        // Another application of the "out" modifier in a .Net method TryParse, A try-catch equivalent of the "parse" method.

        int parseResult;
        bool isParseSucessful = int.TryParse("Abc", out parseResult);
        if (isParseSucessful)
            Console.WriteLine(parseResult);
        else
            Console.WriteLine("Parse failed");
    }






    /* The "params" method modifier enables a function to spread out an array of input
     * as comma separed individual arguments, just like the spread operator in javascript.
     * It allows a method to take a variable number of same type arguments. 
     
     It is good to note the following.
        1) The "params" modifier must be applied as the last argument of the method
        2) The array can also be explicitly passed instead of the comma separated arguments
        3) The parameters of the method could also be empty and accept no parameters at call
        4) "params" can be comined with other parameters in the same method signature.

      The method below can be called with any number of integers
    */
    public static int Add(params int[] nums)
    {
        int result = 0;
        foreach (var num in nums)
            result += num;
        return result;
    }






    /* The "ref" method modifier is used to pass the actual reference of value types to a method.
       This entails that as oppsed to the method having a copy of the variable passed to it,
       it now posesses the actual reference to the variable, and any modification made to the
       argument passed to the methd would reflect on the variable outside the method, which was passed
       to the method.

     It is good to note the following
        1) The value passed to the method must be pre-initialized.
        2) The "ref" keyword must be present in both the method input signature and invocation.
        3) This method can make code less readable and complex.

        When the method below is called, it modifies the actual value of the variable passed to
       it.
    */
    public static void MutateScore(ref int score)
    {
        score = 34;
    }






    /* The "out" modifier is used to output values from a method (even if its return type is marked void)
     * The "out" modifier is another approach to returning values from a method.
     * 
     It is good to note the following
        1) An assignment operation must be made to the out arguments within the method
        2) A method can return more than 1 value with the "out" modifier
        3) Out modifier parameters need not be initialized before being passed to the function
           As the function would assign a value to them when it runs.
    */
    public static void Divide(int dividend, int divisor, out int quotient, out int remainder)
    {
        quotient = dividend / divisor;
        remainder = dividend % divisor;
    }

}

