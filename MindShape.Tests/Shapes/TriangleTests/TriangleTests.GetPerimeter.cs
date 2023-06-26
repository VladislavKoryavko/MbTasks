using MindShape.Lib.Shapes;

namespace MindShape.Tests.Shapes.TriangleTests;

public partial class TriangleTests
{
    [Fact]
    public void GetPerimeter()
    {
        // Arrange
        var sides = new List<double> { 3, 4, 5 };
        var triangle = new Triangle(sides);

        // Act
        var result = triangle.GetPerimeter();

        // Assert
        Assert.Equal(12, result);
    }
}