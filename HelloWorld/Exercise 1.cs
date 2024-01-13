using System;
namespace HelloWorld
{
	public class Exercise_1
	{
		public static void Question1()
		{
			//using If-Else Statement
			var numInput = int.Parse(Console.ReadLine());
			if (numInput >= 0 && numInput <=10)
			{
				Console.WriteLine("Valid");
			}
			else
			{
				Console.WriteLine("Invalid");
			}

			//using Ternary Operator
			string res = (numInput >= 0 && numInput <= 10) ? res = "Valid" : res = "Invalid";
			Console.WriteLine(res);
		}

		/* Program to read 2 numbers from the console and log out the the greater of both */
		public static void Question2()
		{
			
			int[] numArr = new int[2];

			
			for (int i = 0; i < 2; i++)
			{
				numArr[i] = int.Parse(Console.ReadLine());
			}

			int maxNum = numArr[0];
			for (int i = 0; i < 2; i++)
			{
				if (numArr[i] > maxNum)
				{
					maxNum = numArr[i];
				}
			}
			Console.WriteLine(maxNum);

		}

		/* A program that classifies the orientation of an image based on the height and width values */
		public static void Question3()
		{
			int[] inputs = new int[2];
			for (int i = 0; i < 2; i++)
            {
				if (i == 0)
					Console.Write("Enter image width: ");
				else if (i == 1)
                    Console.Write("Enter image height: ");

                inputs[i] = int.Parse(Console.ReadLine());
			}
            if (inputs[0] > inputs[1])
                Console.WriteLine("Image is in landscape orientation");
            else if (inputs[1] > inputs[0])
                Console.WriteLine("Image is in portrait orientation");
            else
                Console.WriteLine("Image has a square aspect ratio");
        }
	}

}