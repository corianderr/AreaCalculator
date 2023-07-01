namespace AreaCalculator.Tests;

public class CircleTests
{
    [Fact]
    public void CalculateArea_ValidRadius_ReturnsCorrectArea()
    {
        // Arrange
        double radius = 5;
        var circle = new Circle(radius);

        // Act
        var area = circle.Area;

        // Assert
        Assert.Equal(Math.PI * radius * radius, area);
    }

    [Fact]
    public void CalculateArea_NegativeRadius_ThrowsArgumentOutOfRangeException()
    {
        // Arrange, Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
    }
}