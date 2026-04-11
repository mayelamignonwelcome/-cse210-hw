using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test individual shapes
        Square square = new Square("Red", 5);
        Console.WriteLine($"Square color: {square.GetColor()}");
        Console.WriteLine($"Square area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Console.WriteLine($"Rectangle color: {rectangle.GetColor()}");
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Circle color: {circle.GetColor()}");
        Console.WriteLine($"Circle area: {circle.GetArea()}");

        // Build a list of shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.WriteLine("\nIterating through shapes:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
