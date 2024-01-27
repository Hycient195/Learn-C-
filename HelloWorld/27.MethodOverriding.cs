using System;
namespace HelloWorld
{
	public class Shape
	{
		public int Height { get; set; }
		public int Width { get; set; }

		// Using the "virtual" keyword is an indication that this method is allowed to be overridden by an inheriting child class.
		public virtual void Draw()
		{
			Console.WriteLine("Shape drawn ");
		}
	}

	public class Rectangle: Shape
	{
		// Override is used to change the implementation of a parent class method, in a child class
        public override void Draw()
        {
			// Rectangle class specific implementation of the Dray functionality.
            base.Draw(); // This is called if there is some functionality in the base class method that still needs to be executed in the child class.
        }
    }
}

/* Method overriding is a practic used to create a different implementation of the behoviour
 * of a parent class method, in a child class. This could be that the implemtation of the
   behaviour may not be generically implementable in the parent class, and as such has
   to be implemented in the inheriting child class. And example can be seen in the draw method
   above. It makes no sense to draw a shape, because what type could the shape be, but it
   makes perfect sense to draw a circle. */