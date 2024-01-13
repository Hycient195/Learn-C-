using System;

public class RandomNumbers
{
    public static void RandomPractice()
    {
        RandomNumber();
        RandomByteArray();
        RandomPasswordGenerator(15);
    }
    /* Generating a random number */
    public static void RandomNumber()
    {
        Random randomizer = new Random();
        int randNum = randomizer.Next(20, 30);
        Console.WriteLine(randNum);
    }


    /* Generating an array containing random bytes within range of 0 to +255 */
    public static void RandomByteArray()
    {
        Random randomizer = new Random();
        byte[] byteArr = new byte[5];
        randomizer.NextBytes(byteArr);
        foreach (var each in byteArr)
        {
            Console.WriteLine(each);
        }
    }

    /* Using my knowledge from random number generation and typecasting ASCII
    *  codes to alphabets for random password generator */
    public static void RandomPasswordGenerator(int passwordLength)
    {
        char[] passwordBuffer = new char[passwordLength];
        var randomizer = new Random();

        for (int i = 0; i < passwordLength; i++)
        {
            passwordBuffer[i] = (char)randomizer.Next(0, 121);
        }
        string result = new string(passwordBuffer);
        Console.WriteLine(result);
    }


    /* ==================================== */
    /* Entry Point for all exercises */
    /* ==================================== */
    public static void RandomExercises()
    {
        //Exercise1();
        //Exercise2();
        //Exercise3(5);
        //Exercise4();
        Exercise5();
    }

    /* A program that counts how many numbers between 0 to 100 are divisible by 3 */
    public static void Exercise1()
    {
        Console.WriteLine("Exercise 1");
        byte resultCount = 0;
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
                resultCount += 1;
        }
        Console.WriteLine(resultCount);
    }

    /* A program that progressively adds all numbers entered in the console till "ok" is entered */
    public static void Exercise2()
    {
        Console.WriteLine("Exercise 2");
        int result = 0;
        while (true)
        {
            Console.WriteLine("Enter a number to progressively add. Enter \"ok\" to exit");
            var input = Console.ReadLine();
            if (input == "ok")
                break;
            else 
                result += Convert.ToInt32(input);
        }
        Console.WriteLine("Summation of all numbers is {0}", result);
    }

    /* Number Factorial Calculator */
    public static void Exercise3(int input)
    {
        Console.WriteLine("Exercise 3");
        int result = input;
        for (int i = (input - 1); i > 0; i--)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }

    /* Random Number Guess Game. Guess in 4 trials the mystery number within 1 and 10 */
    public static void Exercise4()
    {
        Console.WriteLine("Exercise 3");
        Random randomizer = new Random();
        int randnum = randomizer.Next(1, 10);
        int trials = 4;
        Console.WriteLine("Enter mystery number");
        Console.WriteLine(randnum);
        for (int i = 0; i < trials; i++)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == randnum)
            {
                Console.WriteLine("You won");
                break;
            }
            else
                if (i == (trials - 1))
                    Console.WriteLine("You lost!");
                else
                    Console.WriteLine("Try again");
        }
    }

    /* Program that finds the maximum number from a string of comma separated values */
    public static void Exercise5()
    {
        Console.WriteLine("Exercise 5");
        Console.WriteLine("Enter a comma separated list of numbers");
        string input = Console.ReadLine();
        var stringArr = input.Split(',');
        int[] numArr = new int[stringArr.Length];
        for (int i = 0; i < stringArr.Length; i++)
        {
            numArr[i] = int.Parse(stringArr[i]);
        }

        int maxNum = numArr[0];

        for (int i = 0; i < numArr.Length; i++)
        {
            if (numArr[i] > maxNum)
                maxNum = numArr[i];
        }

        Console.WriteLine("The maximum number is {0}", maxNum);
    }
}