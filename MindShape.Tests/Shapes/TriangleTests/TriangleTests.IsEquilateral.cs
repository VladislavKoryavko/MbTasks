using MindShape.Lib.Shapes;

namespace MindShape.Tests.Shapes.TriangleTests;

public partial class TriangleTests
{
    [Fact]
    public void IsEquilateral()
    {
        // Arrange
        var sides = new List<double> { 3, 3, 3 };
        var triangle = new Triangle(sides);

        // Act
        var result = triangle.IsEquilateral();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEquilateralWhenNotEquilateral()
    {
        // Arrange
        var sides = new List<double> { 3, 4, 5 };
        var triangle = new Triangle(sides);

        // Act
        var result = triangle.IsEquilateral();

        // Assert
        Assert.False(result);
    }
}