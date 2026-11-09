using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(4, "White");
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle(3, 2, "Blue");
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle(4, "Purple");
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes){
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color: {color} | Area: {area}");
        }
        
    }
}