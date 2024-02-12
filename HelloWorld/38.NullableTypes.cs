using System;
namespace HelloWorld
{
	public class NullableTypes
	{
		public static void EntryPoint()
		{
			Nullable<int> nullNum = null; // How to declare a nullable type
			int? nullNum2 = null; // Shorthand syntax for declaring an nullable type.

			//int notNull = nullNum2; // You cannot assign a nullable to a non nullable type. Instead use
			int notNull = nullNum2.GetValueOrDefault();

			/* Nullable types have 3 distinct methods */
			var valueOrDefault = nullNum.GetValueOrDefault(); // Returns the value of the nullable type if it exists, or the defult value of its type if it does not exist.
			Console.WriteLine("Getting the value or default of a null variable: " + valueOrDefault);

			var hasValue = nullNum2.HasValue; // Returns a boolean corresponding if the nullable has a value or not.
			Console.WriteLine("Checking if a nullable has a value: " + hasValue);


			// Commented out for wrongness
            //var value = nullNum.Value; // Returns the value of the nullable, if it exists, or an exception, if it doesn't
            //Console.WriteLine("Getting value of a nullish variable: " + value); // This may be erronous. Use "GetValueOrDefault()" for most cases to get the value of a nullable type.


			/* Nullish Coalescing */
			// This practice is used to assign a nullable to a variable if it has a value, or
			// Some other value if the nullable is null

			int nullNum3 = nullNum ?? 20; // In this case nullNum3 would be 20 because "nullNum" is null
			Console.WriteLine("Nullish Coalescing: " + nullNum3);

			// This can also be acheived with a ternary operator as seen below.
			int nullNum4 = (nullNum != null) ? nullNum.GetValueOrDefault() : 50;
			Console.WriteLine("Nullish Coalescing with ternary: " + nullNum4);
		}
	}
}

/* A nullable type is a type that can be assigned a value or set to "null". Nullable types are
 * commonly used on value types to represent the abscence of a value, since by default, value
   types must have a value.
	 Nullable types simply allows you to assign a value to its type or otherwise assign "null".*/