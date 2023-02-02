public class Fraction {

    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int topNumer)
    {
        _top = topNumer;
        _bottom = 1;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottomNumer)
    {
        _bottom = bottomNumer;
    }

    public void GetFractionString()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public double GetDecimalValue()
    {
        return (double) _top/ (double) _bottom;
    }



}