using System;
namespace HelloWorld
{
	public class LambdaExpression
	{
		// Assigning the reference of a lambda expression to a delegate
		Func<int, int, int> Add = (a, b) => a + b;

		public static void EntryPoint()
		{
            var digits = new List<int>() { 1, 2, 3, 4, 5 };

			// Use of a lambda expression as a predicate to a method.
			var result = digits.FindAll(x => x > 3);

			foreach (int digit in result)
				Console.WriteLine(digit);
        }

	}
}


/* A lambda expression is very similar to the arrow function in JavaScript. 
 It is an anonymous function or method, used to perform a one time operation,
 and It is a shorthand syntax used to define a method.
	Since it is an anomymous function, it can be assigned to a delegate like
 the Func<> or Action<> delegate to hold a reference to it, its count of input
 and output parameters, and their types.

 A Lambda expression is also called a "Predicate", and can be passed to methods
 on enumarables like the Find, FindAll, FindLast, etc. */