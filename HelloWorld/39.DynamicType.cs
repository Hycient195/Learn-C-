using System;
namespace HelloWorld
{
	public class DynamicType
	{
		public static void Entrypoint()
		{
			dynamic dynamicVar = "Hello";
			dynamicVar = 10;
			dynamicVar++;

			Console.WriteLine("Result of dynamic operation: " + dynamicVar);
			// The above operation is only possible because an integer was assigned
			// to the dynamic variable before is was increamented using the ++ operator.


			dynamic food = new { name = "Cabbage", price = 300 };
			Console.WriteLine(food.name);

		}
	}
}

/* The "dynamic" keyword is used to define a type in C# whoose value is inferred not at compile time,
 * but rather at runtime as seen in other C# types. The "dynamic" keyword makes C# behave like other
 * interpreted langauges like JavaScript. whose types are inferred at runtime.

	 The dynamic keyword is a type of the DLR (Dynamic Langauge Runtime) introduced in C# 4.0,
   which was built upon the CLR (Common Langauge Runtime).

   The "dynamic" keyword are used to initialze variables whoose types are not known till runtime.

   It is good to note that errors resulting from dynamic types can only be caught in run time, and
   cannot be caught in compile time because their types are not yet known at compile time.

   It is also good to ensure the judicious use of the dynamic keyword as it sacrifices the compile-time
   safety provided by C#, which can result in compile-time errors which are more difficult to debug
*/