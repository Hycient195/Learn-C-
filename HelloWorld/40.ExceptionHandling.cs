using System;
namespace HelloWorld
{
	public class ExceptionHandling
	{
		public static void Entrypoint()
		{
			try
			{
				var outcome = Divide(25, 0); // Erronous operation.
			}
			/* Exception with filters. This catches error based on certain crieteria */
			catch (DivideByZeroException ex) when (ex.Message == "Attempted to divide by zero.")
			{
				Console.WriteLine("Exception with condition encountered");
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("Cannot divide by zero");
				throw new CustomArithimeticException("Custom exception encountered", ex);
			}
			catch (ArithmeticException ex)
			{
				Console.WriteLine("An arithimetic error occoured");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Something went wrong in the application");
			}
			finally
			{
				Console.WriteLine("Division operation has been completed");
			}
		}

		public static int Divide(int a, int b)
		{
			return a / b;
		}
	}

	// Deriving a custom exception from the "Exception" base class
	public class CustomArithimeticException : Exception
	{
		public CustomArithimeticException(string message, Exception ex)
			: base(message, ex)
		{
			Console.WriteLine(message);
		}
	}
}

/* Exception handling in C# is a mechanism used to handle runtime errors, exceptiona and abnormal
 * conditions, and prevent the crashing of an application or provide a means to recover from errors.
 * 
 *   Exception handling in C# is handled by the use of the "Try-Catch" block.
 * 
 *   It is good to note that exceptions follow a heirachy, and more precise exceptions derive from
 * more generic exceptions which are shared by two or more precise exceptions. For example, as seen
 * above, the "DivideByZeroException" inherits from the "ArithimeticException" (which is shared by
 * other arithimetic operations) of which the "ArithimeticException" further down the line derived
 * from the "Exception" class.
 * 
 *   It is also good to note that when catching exceptions, the more precise exceptions must come
 * first before the base or parent exceptions, as if the base excepions come first, they would
 * overshadow the more precise exceptions, and ordinarily, the compiler would not allow this.
 * 
 *   The "finally" block is specified after all the catch blocks. It executes after the operation in
 * the "try" block, after whether or not an exception is encountered. It is mostly used to clean or
 * dispose off resources used in the "try" block that ordinarily, the C# langauge garbage collector
 * do not automatically dispose. Most of the dispose operations (eg from stream reader, database 
 * connections etc) implement the "IDisposable" interface that contains a "Dispose" method.
 * 
 *   Also, the developer can also create custom exceptions that derive from the base "Exception"
 * class, the write logic that is very specific to a certain kind of exception that is specific to a
 * user implemented operation. In most cases the custom exception which inherit the "Exception" class
 * could make a call to the "base()" constructor and pass the message and received exception to it
 * as arguments. The exception received would be referred to as the "InnerException"
 * 
 *   The developer can also throw exceptions based on custom conditions using the "throw" keyword
 * (eg throw new CustomArithimeticException("Something went wrong, ex))
 * 
 *   Also, from C# 6 Exception filters can also block exceptions based on certain crieteria using
 * the "when" keyword as seen above.
 * eg. catch (DivideByZeroException ex) when (ex.Message == "Attempted to divide by zero.")
 * {}
 */