namespace AreaCalculator.Tests;

public class TriangleTests
{
    [Fact]
    public void CalculateArea_ValidSides_ReturnsCorrectArea()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        // Act
        double area = triangle.Area;

        // Assert
        Assert.Equal(6, area);
    }

    [Fact]
    public void CalculateArea_InvalidSides_ThrowsArgumentOutOfRangeException()
    {
        // Arrange, Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 2, 3));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, -2, 3));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 2, -3));
    }

    [Fact]
    public void IsRightAngled_RightAngledTriangle_ReturnsTrue()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        // Act
        bool isRightAngled = triangle.IsRightAngled;

        // Assert
        Assert.True(isRightAngled);
    }
}