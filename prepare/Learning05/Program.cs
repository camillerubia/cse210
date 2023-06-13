using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Console.Clear();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("green", 5));
        shapes.Add(new Rectangle("red", 2, 5));
        shapes.Add(new Circle("white", 5));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            Console.WriteLine(color);
            double area = shape.GetArea();
            Console.WriteLine(area);
        }
    }
}