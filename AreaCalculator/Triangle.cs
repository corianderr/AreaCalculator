namespace AreaCalculator;

public class Triangle : Figure
{
    private double _halfPerimeter;
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
    /// <summary>
    /// Perimeter of a triangle.
    /// </summary>
    public double HalfPerimeter
    {
        get
        {
            if (_halfPerimeter == 0) _halfPerimeter = CalculatePerimeter() / 2;
            return _halfPerimeter;
        }
    }
    /// <summary>
    /// Perimeter of a triangle.
    /// </summary>
    public bool IsRightAngled { get; }
    
    /// <summary>
    /// Represents a figure with three corners (triangle) and provides option to calculate and use its area..
    /// </summary>
    /// <param name="firstSide">First side of a triangle.</param>
    /// <param name="secondSide">Second side of a triangle.</param>
    /// <param name="thirdSide">Third side of a triangle.</param>
    /// <exception cref="ArgumentOutOfRangeException">If any of the sides is less than zero.</exception>
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0) 
            throw new ArgumentOutOfRangeException(nameof(firstSide),"Side of a triangle must be positive.");
        if (secondSide <= 0) 
            throw new ArgumentOutOfRangeException(nameof(secondSide),"Side of a triangle must be positive.");
        if (thirdSide <= 0) 
            throw new ArgumentOutOfRangeException(nameof(thirdSide),"Side of a triangle must be positive.");

        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
        IsRightAngled = CheckIsRightAngled();
    }
    
    protected sealed override double CalculateArea()
    {
        return Math.Sqrt(HalfPerimeter * (HalfPerimeter - FirstSide) * (HalfPerimeter - SecondSide) * (HalfPerimeter - ThirdSide));
    }

    /// <summary>
    /// Calculates perimeter of a triangle.
    /// </summary>
    /// <returns>Floating point value of perimeter.</returns>
    private double CalculatePerimeter()
    {
        return FirstSide + SecondSide + ThirdSide;
    }

    /// <summary>
    /// Checks whether triangle is right-angled.
    /// </summary>
    /// <returns>True if triangle is right-angled, otherwise false.</returns>
    private bool CheckIsRightAngled()
    {
        var maxSide = new[] { FirstSide, SecondSide, ThirdSide }.Max();
        var maxSquare = maxSide * maxSide;
        var sqrSum = FirstSide * FirstSide + SecondSide * SecondSide + ThirdSide * ThirdSide;
        return Math.Abs(maxSquare * 2 - sqrSum) < 0.00000001;
    }
}