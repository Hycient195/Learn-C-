class Loops
{
    public static void Entrypoint()
    {
        ForLoops();
        ForEachLoop();
        WhileLoop();
    }

    public static void ForLoops()
    {
        for (var i = 0; i <= 10; i++)
        {
            Console.WriteLine("Working with for loop45");
        }
    }

    public static void ForEachLoop()
    {
        // This kind of loop is used on iterables like array and list
        var numbers = new[] { 1, 2, 3, 4, 5 };
        foreach (var number in numbers)
            Console.WriteLine(number + " ");
    }

    public static void WhileLoop()
    {
        var i = 0;
        while (i < 4)
        {
            i++;
        }
    }
    // Do-while loop. Similar to while loop, but executes at leas once, before
    // evaluating loop conditions.
}