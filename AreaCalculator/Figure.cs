namespace AreaCalculator;

public abstract class Figure
{
    private double _area;
    public double Area {
        get
        {
            if (_area == 0) _area = CalculateArea();
            return _area;
        }
        set => _area = value;
    }

    protected abstract double CalculateArea();
}