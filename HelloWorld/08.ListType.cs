public class ListType
{
    public static void Entrypoint()
    {
        //Practice
        //BasicList();

        // Exercoses
        //Exercise1();
        //Exercise2();
        //Exercise3();
        //Exercise4();
        //Exercise5();
    }

    public static void BasicList ()
    {
        /* A list is a group of relatied items. but Unlike arrays, the size of
         * a list is expandable as more items are added to it, as its size is 
         * likely not to be known beforehand during intialization */

        List<int> scores = new List<int>()
        {
            29, 58, 29, 32, 29, 58
        };
        // Adding items to the list.
        scores.Add(49);
        scores.Add(20);
        scores.Add(64);
        scores.AddRange(new int[] { 12, 34, 56 }) // Adds an array or list of values
;
        foreach (var score in scores)
            Console.Write(score + " ");

        scores.Remove(58); // Removes first occourence of argument;
        scores.RemoveAll(x => x == 29); // Takes a callback and removed all occourene for true condition
        Console.WriteLine();
        foreach (var score in scores)
            Console.Write(score + " ");

        scores.Clear(); // Removes all items from the List.
        Console.WriteLine("\n List count is: " + scores.Count);
    }


    /* A program that takes different names in the console, and displays
     * them in Facebook's style of number of likes */
    public static void Exercise1()
    {
        List<string> namesOfPostLikers = new List<string>();
        Console.WriteLine("Enter the name of people who liked post");
        while (true)
        {
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
                break;
            namesOfPostLikers.Add(name);
        }

        string result = "";
        result += !string.IsNullOrEmpty(namesOfPostLikers[0]) ? namesOfPostLikers[0] + ", " : "";
        result += !string.IsNullOrEmpty(namesOfPostLikers[1]) ? namesOfPostLikers[1] + " " : "";
        result += !string.IsNullOrEmpty(namesOfPostLikers[2]) ? ("and " + (namesOfPostLikers.Count - 2) + " other(s) ") : "";
        result += "Liked your post";
        Console.WriteLine(result);

    }

    /// <summary>
    /// Write a program and ask the user to enter their name. Use an array to
    /// reverse the name and then store the result in a new string. Display the
    /// reversed name on the console.
    /// </summary>
    public static void Exercise2()
    {
        var nameInArrayForm = Console.ReadLine();
        // STRINGS ARE IMMUTABLE
        Console.WriteLine(new string(nameInArrayForm.Reverse().ToArray()));
        
    }

    /// <summary>
    /// Write a program and ask the user to enter 5 numbers. If a number has been
    /// previously entered, display an error message and ask the user to re-try.
    /// Once the user successfully enters 5 unique numbers, sort them and display
    /// the result on the console.
    /// </summary>
    public static void Exercise3()
    {
        Console.WriteLine("Enter 5 numbers one after a time");
        List<int> numbers = new List<int>();
        int iterationCount = 0;
        while (true)
        {
            if (iterationCount == 5)
                break;

            int input = int.Parse(Console.ReadLine());
            if (!numbers.Contains(input))
            {
                numbers.Add(input);
                iterationCount++;
            }
            else
                Console.WriteLine("Number already exists. Try again");
        }
        numbers.Sort();
        foreach (var item in numbers)
            Console.Write(item); ;
    }

    /// <summary>
    /// Write a program and ask the user to continuously enter a number or type "Quit"
    /// to exit. The list of numbers may include duplicates. Display the unique numbers
    /// that the user has entered.
    /// </summary>
    public static void Exercise4()
    {
        Console.WriteLine("Continoursly Enter numbers. Type \"quit\" to exit and print unique numbers");

        List<int> uniqueNumbers = new List<int>();
        while (true)
        {
            Console.WriteLine("Enter number");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            else if (!uniqueNumbers.Contains(Convert.ToInt32(input)))
                uniqueNumbers.Add(Convert.ToInt32(input));
        }
        foreach (var item in uniqueNumbers)
            Console.Write(item);
        Console.WriteLine();
    }

    /// <summary>
    /// Write a program and ask the user to supply a list of comma separated numbers
    /// (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers,
    /// display "Invalid List" and ask the user to re-try; otherwise, display the 3
    /// smallest numbers in the list.
    /// </summary>
    public static void Exercise5()
    {
        while (true)
        {
            Console.WriteLine("Enter a list of comma separated numbers");
            string[] stringArr = Console.ReadLine().Split(','); ; ;
            List<int> numArr = new List<int>();
            foreach (var item in stringArr)
                if (!numArr.Contains(Convert.ToInt32(item)))
                numArr.Add(Convert.ToInt32(item));

            if (stringArr.Length < 5)
                Console.WriteLine("Invalid List. Retry");
            else
            {
                numArr.Sort();
                for (int i = 0; i < 3; i++)
                    Console.WriteLine(numArr[i]);
                break;
            }
        }
    }
}