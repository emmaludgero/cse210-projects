class Program
{
    
    static void Main()
    {
        Console.WriteLine("Hello Circle");
        Circle myCircle = new Circle(10);

        double area = myCircle.GetArea();
        double diameter = myCircle.GetDiameter();
        double circumference = myCircle.GetCircumference();

        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Diameter: {diameter}");
        Console.WriteLine($"Circumference: {circumference}");
    }
}