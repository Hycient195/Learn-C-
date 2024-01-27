using System;
namespace HelloWorld
{

	public class NumberCalculator
	{
		public delegate void NumberCalculatorDelegate(int a, int b);

		public void Add(int a, int b)
		{
			Console.WriteLine("Sum of numbers is: " + (a + b));
		}

		public void Subtract(int a, int b)
		{
			Console.WriteLine("Difference of numbers is: " + (a - b));
		}

		public void Divide(int a, int b)
		{
			Console.WriteLine("Quotient of numbers is: " + (a / b));
		}

		// Using the Func delegate;
		Func<int, int> square;

		public int Square(int arg)
		{
			return arg * arg;
		}

		public int ReturnInput(int arg)
		{
			return arg;
		}

		public void PerformSquare()
		{
			
			square = Square; // The "Square" method is assigned to the "square" delegate.
			square += ReturnInput;
			Console.WriteLine(square(4)); ;
		}
	}

}

/* A delegate is simply a reference to a method, or group of methods. To make use of a delegate,
 * the delegate is created, and after that, a variable with the delegate as type is created
 * a method with the same signature as the delegate is assigned to the variable. After that,
 * other methods with similar signatures to the delegate, can then be assigned to the delegate
 * using the += operator. After that can be done, the delegate can then be executed, and 
 * arguments passed to it (if any), and all the methods assiciated with the deledate will be
 * simultaneously executed. */

/* Furthermore, the "Func<>" and "Action<>" typesafe generic delegate types make the creation
 * of delegates even more seamless. The Func<> generic delegate takes up to 16 generic parameters
 * of which the last parameters corresponds to the output type, and the rest are for input types.
 * They can be created, and the methods with similar signatures can thn be chained to the 
 * delegate, and the delegate invoked.
 *	The Action<> generic delegate is similar to the Func<> generic deldgate, but unlike the
 * Func<> generic delegate, it returns void. */

/* It is good to note that the signature of all the methods to be associated with
 * The delegate, and the delegate itself must all have the same signature, for the
   delegated operation to be sucessful */