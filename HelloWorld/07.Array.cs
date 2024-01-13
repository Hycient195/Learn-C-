// length, indexof, clear, copy, sort, reverse

public class ArrayTypes
{
    public static void Entrypoint()
    {
		//BasicMethods();
		//RectangularArray();
		//JaggedArray();

    }

    public static void BasicMethods()
	{
		// This syntax can be used when declaring and initializing the array
		// all at once, as the length and type can already be inferred
		int[] numArr = new[] { 5, 2, 7, 4, 2, 8, 4, 1 };

		Console.WriteLine(numArr.Length);

		Console.WriteLine(Array.IndexOf(numArr, 2));

		Array.Sort(numArr); // Sorts the given array by directly mutating its value.
		Console.WriteLine("The elements of the sorted array are: ");
		foreach (var num in numArr)
			Console.Write(num);

		var newNumArr = new int[4];
		Array.Copy(numArr, newNumArr, 4); // Copies from a source array to a destination array
		Console.WriteLine("\nThe elements of the copied array are: ");
		foreach (var num in newNumArr)
			Console.Write(num);

		var newArrayTwo = new int[5];
		Array.Copy(numArr, 4, newArrayTwo, 1, 2); // Anoter Copy method overload similar to "Array.ConstrainedCopy"
        Console.WriteLine("\nThe elements of the second copied array are: ");
        foreach (var num in newArrayTwo)
            Console.Write(num);

		Array.Reverse(numArr);
		Console.WriteLine("\nReversed Array");
        foreach (var num in numArr)
            Console.Write(num);
		Console.WriteLine();

		/* It is good to note that array methods are of two kinds; the static methods
		 * ones on the Array class and the instace method on the object instance of the
		 * created array. It is also good to observe that Array static methods directly
		 * modify the array on which they perform operations on, while methods on the
		 * array instance return a new array with the modifications (if any) and to not
		 * mutate the original array.
		 */
    }

	public static void RectangularArray()
	{
		/* A multidimensional or rectangular array can be defined as thus 
		An array is said to be rectangular if the length of all of its sub
		arrays are equal. A multi-dimensional array can have 2,3,4, etc
		dimensions of arrays */
		char[,] brokenWord = new char[3, 4]
		{
			{ 'f','e','n','d' },
            { 'f','i','n','d' },
            { 'f','u','n','d' }
        };
		/* Nested values can be accessed as seen below */
		Console.WriteLine(brokenWord[0,1]);

		// Listing all of its constituents
		foreach (var letter in brokenWord)
			Console.Write(letter);
	}

	public static void JaggedArray()
	{
		/* A jagged array is one whose sub-array children are not equal in length
		 * and as such, all the size of all of its constituents have to be 
		 individuall defined */

		Console.WriteLine("\nWorking with Jagged Arrays");
		char[][] words = new char[3][];
		words[0] = new char[2] { 'd', 'o'};
		words[1] = new char[3] { 't', 'h', 'e'};
		words[2] = new char[4] { 'b', 'e', 's' ,'t'};

		// Printing its content to the console
		foreach (char[] outer in words)
		{
            foreach (char inner in outer)
                Console.Write(inner);
			Console.WriteLine();
        }

		// They can also be created on the fly as seen below
		int[][] jaggedIntArray = new[]{
			new[] { 1,2 },
			new[] { 3, 4, 5, 6 },
			new[] { 7, 8, 9 }
		};
					
	}
}