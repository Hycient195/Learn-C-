using System;
public class Point
{
    public int X;
    public int Y;
    public int Speed;

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(Point destination)
    {
        Move(destination.X, destination.Y);
    }

    public void Move(Point destination, int speed)
    {
        Move(destination);
        this.Speed = speed;
    }
}
/* As seen in the "Move" method overloads, one overload can make call or invoke
 * another overload, to pass arguments to it, in order to reduce code duplication
 */