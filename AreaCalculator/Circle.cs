namespace AreaCalculator;

public class Circle : Figure
{
    /// <summary>
    /// Radius of circle.
    /// </summary>
    private double Radius { get; }
    
    /// <summary>
    /// Represents a figure without corners (circle) and provides option to calculate and use its area.
    /// </summary>
    /// <param name="radius">Radius of circle.</param>
    /// <exception cref="ArgumentOutOfRangeException">If radius is less than zero.</exception>
    public Circle(double radius)
    {
        if (radius <= 0) 
            throw new ArgumentOutOfRangeException(nameof(radius),"Radius must be positive.");
        Radius = radius;
    }

    protected sealed override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}