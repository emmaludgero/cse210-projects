class Circle
{
    
    private double _radius;
    private double _pi = 3.14159;

    public Circle()
    {
        _radius = 1.0;
    }

    public Circle(double radius)
    {
        SetRadius(radius);
    }
    public double GetArea()
    {
        return _radius * _radius * _pi;
    }
    public double GetCircumference()
    {
        return 2 * _pi * _radius;
    }
    public double GetDiameter()
    {
        return 2 * _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }
}