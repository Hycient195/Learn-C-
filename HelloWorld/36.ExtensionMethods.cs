using System;
using System.Linq;

namespace System
{
	public static class StringExtensions
	{
		public static string Truncate(this string word, int wordCount)
		{
			if (string.IsNullOrEmpty(word))
				throw new NullReferenceException("String provided is null");

			if (wordCount <= 0)
				throw new ArgumentOutOfRangeException("Value provided in invalid");

			return string.Join(" ", word.Split(" ").Take(wordCount)) + "...";
		}
	}

	public static class IntExtensions
	{
		public static int Power(this int p)
		{
			return p * p;
		}
	}
}

/* An extension method is a utility used to add functionality to a class or interface,
 * without altering the source code of that class or type. It is very useful when you
 * want to add functionality to a class, type or interface whom you don't have access 
 * to its source file (inbuilt classes, interfaces and types), and cannot control or
 * modify them directly. 
 
	An extension method is defined in a static class, which houses the static extension
   method. The method takes the "this" keyword supplied before the type to be extended,
   and then a variable name, which referes to the instance of that type on which the method
   is called on. Any operation may then be carried out, and a value or void may be
   returned.

    Though the class and method is static, they can still then be acessible on any
   variable created as an instance of the type they have been declared on, because they
   are extension methods.
 */