// Trim, Uppercase, Lowercase indexof substring split replace nullcheck conversions
using System.Linq;
using System.Text;

public class StringType
{
    public static void EntryPoint()
    {
        /* Practice */
        //StringMethods();StringBuilderMethods()
        //StringBuilderMethods();

        /* Exercises */
        //Exercise1();
        //Exercise2();
        //Exercise3();
        //Exercise4();
        //Exercise5();
    }

    public static void  StringMethods()
    {
        string fullName = "Hycient Onyeukwu ";
        Console.WriteLine("With space trimmed '{0}'", fullName.Trim()); // Removes end trailing space

        Console.WriteLine("In upper case: " + fullName.ToUpper()); // Uppercase;
        Console.WriteLine("In lower case: " + fullName.ToLower()); // Lowercase;

        Console.WriteLine(fullName.IndexOf('y')); // returns index of first occourence
        Console.WriteLine(fullName.LastIndexOf('y')); // return last index of occourence

        Console.WriteLine("Substring with only start index: " + fullName.Substring(8)); // From index to the end
        Console.WriteLine("Substring with start and end index: " + fullName.Substring(8,4));

        string[] splittedName = fullName.Split(" ");
        foreach (var name in splittedName)
            Console.WriteLine(name);

        Console.WriteLine(fullName.Replace("Hycient", "Hye"));

        if (String.IsNullOrWhiteSpace(" "))
            Console.WriteLine("String is nullish");


        /* Conversions from string to number */
        string numStr = "6145";
        int convertedToNumber1 = int.Parse(numStr);
        int convertedToNumber2 = Convert.ToInt32(numStr);
        Console.WriteLine(convertedToNumber1 + " " + convertedToNumber2);

        /* Conversions from number to string */
        int numericNumber = 28594;
        Console.WriteLine("Number to string: " + numericNumber.ToString());
        Console.WriteLine("Number to currency string: " + numericNumber.ToString("C"));
        Console.WriteLine("Number to currency (1 decimal point): " + numericNumber.ToString("C1"));
        Console.WriteLine("Number to comma separated numbers: " + numericNumber.ToString("N"));
    }

    public static void StringBuilderMethods()
    {
        /* A stringbuilder is simply a variant of a string that is mutable
         * This means that the actual constituents of a stringbuilder can be
          maniuplated on the original string as opposed to the immutability
          obtainable in strings.
        
          To make use of the Stringbuilder class, you would need to import the
          "System.Text" class

          However, a stringbuilder unlike a string does not support search operations
          like IndexOf, Contains, LastIndexOf, etc. It focuses mainly on methods
          revolving around string manipulation. Therefor it has methods like
          Append, Replace, etc.

          It is good to note that each operation on the stringbuilder updates
          or mutates the original string, and returns the new updates, and as
          such, stringbuilder methods can be chained to enhance code readability
         */

        var builder = new StringBuilder("Welcome Home");
        builder.Append(" Have a seat"); // Appending a word;
        builder.Append('g', 4) // Appending a given character for a number of times;
            .Replace("seat", "Bench") // Replaces a word
            .Remove(0, 7) // Removing a start index, a given number of characters
            .Insert(0, "Journey") // Inserts a specific character at a given start index
            .AppendLine("yo");
        Console.WriteLine(builder);
    }

    /* ========= */
    /* Exercises */
    /* ========= */

    /// <summary>
    ///  Write a program and ask the user to enter a few numbers separated by a
    ///  hyphen. Work out if the numbers are consecutive. For example, if the
    ///  input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
    /// </summary>
    public static void Exercise1()
    {
        Console.WriteLine("Input a hyphen (-) separated set of numbers");
        var inputArray = Console.ReadLine().Split("-");

        bool isNumberConsecutive = false;
        for (int i = 0; i < (inputArray.Length - 1); i++)
        {
            Console.WriteLine(Convert.ToInt32(inputArray[i]) + " " + (Convert.ToInt32(inputArray[i + 1]) - 1));
            if ((Convert.ToInt32(inputArray[i]) == (Convert.ToInt32(inputArray[i + 1]) - 1)) || ((Convert.ToInt32(inputArray[i]) == (Convert.ToInt32(inputArray[i + 1]) + 1))))
                isNumberConsecutive = true;
            else
            {
                isNumberConsecutive = false;
                break;
            }
        }
        if (isNumberConsecutive)
            Console.WriteLine("Numbers are consecutive");
        else
            Console.WriteLine("Numbers are not consecutive");
    }

    /// <summary>
    /// Write a program and ask the user to enter a few numbers separated by a hyphen.
    /// If the user simply presses Enter, without supplying an input, exit immediately;
    /// otherwise, check to see if there are duplicates. If so, display "Duplicate" on
    /// the console.
    /// </summary>
    public static void Exercise2()
    {
        Console.WriteLine("Enter a set of hyphen separated numbers");
        var input = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(input))
            return;
        else
        {
            var inputArray = input.Split('-');
            List<int> uniqueItems = new List<int>();

            foreach (var item in inputArray)
            {
                if (!uniqueItems.Contains(Convert.ToInt32(item)))
                    uniqueItems.Add(Convert.ToInt32(item));
                else
                {
                    Console.WriteLine("Duplicate!");
                    break;
                }
            }

        }
    }

    /// <summary>
    /// Write a program and ask the user to enter a time value in the 24-hour time
    /// format (e.g. 19:00). A valid time should be between 00:00 and 23:59.
    /// If the time is valid, display "Ok"; otherwise, display "Invalid Time".
    /// If the user doesn't provide any values, consider it as invalid time.
    /// </summary>
    public static void Exercise3()
    {
        Console.WriteLine("Enter a valid time between 00:00 and 23:59");
        string input = Console.ReadLine();
        string[] timeComponents = input.Split(":");

        if (timeComponents.Length != 2 || String.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid time format");
        }
        else
        {
            int hour = Convert.ToInt32(timeComponents[0]);
            int min = Convert.ToInt32(timeComponents[1]);

            if ((hour >= 0 && hour <= 23) && (min >= 0 && min <= 59))
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Invalid time");
        }
    }

    /// <summary>
    ///  Write a program and ask the user to enter a few words separated by a space.
    ///  Use the words to create a variable name with PascalCase.
    ///  For example, if the user types: "number of students", display "NumberOfStudents".
    ///  Make sure that the program is not dependent on the input.
    ///  So, if the user types "NUMBER OF STUDENTS", the program should still display
    ///  "NumberOfStudents".
    /// </summary>
    public static void Exercise4()
    {
        Console.WriteLine("Enter a set of space separated words to be converted to Pachal Case");
        var inputArray = Console.ReadLine().Split(" ");
        var output = new StringBuilder();
        
        foreach (var word in inputArray)
        {
            output.Append(word.Substring(0, 1).ToUpper());
            output.Append(word.Substring(1).ToLower());
        }
        Console.WriteLine(output);
    }

    /// <summary>
    /// Write a program and ask the user to enter an English word. Count the number of
    /// vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate",
    /// the program should display 6 on the console.
    /// </summary>
    public static void Exercise5()
    {
        Console.WriteLine("Enter a word from which to count the number of vowels");
        var input = Console.ReadLine();
        int vowelCount = 0;
        foreach (var letter in input)
            if (new[] { "a", "e", "i", "o", "u" }.Contains(letter.ToString().ToLower()))
                vowelCount++;

        Console.WriteLine(vowelCount);
    }
}
