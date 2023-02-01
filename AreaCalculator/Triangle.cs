namespace AreaCalculator;

public class Triangle : Figure
{
    private double _perimeter;
    /// <summary>
    /// First side of a triangle.
    /// </summary>
    private double FirstSide { get; }
    /// <summary>
    /// Second side of a triangle.
    /// </summary>
    private double SecondSide { get; }
    /// <summary>
    /// Third side of a triangle.
    /// </summary>
    private double ThirdSide { get; }

    public double Perimeter
    {
        get
        {
            if (_perimeter == 0) _perimeter = CalculatePerimeter();
            return _perimeter;
        }
        set => _perimeter = value;
    }
    
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0) 
            throw new ArgumentOutOfRangeException(nameof(firstSide),"Side of a triangle must be positive.");

        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
        Perimeter = firstSide + secondSide + thirdSide;
    }

    protected sealed override double CalculateArea()
    {
        return Math.Sqrt(Perimeter * (Perimeter - FirstSide) * (Perimeter - SecondSide) * (Perimeter - ThirdSide));
    }

    private double CalculatePerimeter()
    {
        return FirstSide + SecondSide + ThirdSide;
    }
}