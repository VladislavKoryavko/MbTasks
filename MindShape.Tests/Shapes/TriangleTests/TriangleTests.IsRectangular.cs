using MindShape.Lib.Shapes;

namespace MindShape.Tests.Shapes.TriangleTests;

public partial class TriangleTests
{
    [Fact]
    public void IsRectangular()
    {
        // Arrange
        var sides = new List<double> { 3, 4, 5 };
        var triangle = new Triangle(sides);

        // Act
        var result = triangle.IsRectangular();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsRectangularWhenNotRectangular()
    {
        // Arrange
        var sides = new List<double> { 3, 3, 3 };
        var triangle = new Triangle(sides);

        // Act
        var result = triangle.IsRectangular();

        // Assert
        Assert.False(result);
    }
}