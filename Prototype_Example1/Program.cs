using System;

// Prototype interface
interface IShape
{
    IShape Clone();
    void Draw();
}

// Concrete prototypes
class Circle : IShape
{
    private int radius;

    public Circle(int radius)
    {
        this.radius = radius;
    }

    public IShape Clone()
    {
        return new Circle(radius); // Create a copy of the circle
    }

    public void Draw()
    {
        Console.WriteLine($"Draw a circle with radius {radius}");
    }
}

class Rectangle : IShape
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public IShape Clone()
    {
        return new Rectangle(width, height); // Create a copy of the rectangle
    }

    public void Draw()
    {
        Console.WriteLine($"Draw a rectangle with width {width} and height {height}");
    }
}

class Program
{
    static void Main()
    {
        IShape originalCircle = new Circle(10);
        IShape copiedCircle = originalCircle.Clone();
        originalCircle.Draw();
        copiedCircle.Draw();

        IShape originalRectangle = new Rectangle(5, 8);
        IShape copiedRectangle = originalRectangle.Clone();
        originalRectangle.Draw();
        copiedRectangle.Draw();
    }
}
