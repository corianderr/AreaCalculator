namespace AreaCalculator;

public abstract class Figure
{
    private double _area;
    /// <summary>
    /// Figure area.
    /// </summary>
    public double Area {
        get
        {
            if (_area == 0) _area = CalculateArea();
            return _area;
        }
        set => _area = value;
    }
    /// <summary>
    /// Calculates area of a figure.
    /// </summary>
    /// <returns>Floating point value of area.</returns>
    protected abstract double CalculateArea();
}