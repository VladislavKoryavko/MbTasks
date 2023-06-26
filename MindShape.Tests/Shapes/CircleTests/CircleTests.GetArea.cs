using MindShape.Lib.Shapes;

namespace MindShape.Tests.Shapes.CircleTests;

public partial class CircleTests
{
    [Fact]
    public void GetArea()
    {
        // Arrange
        var circle = new Circle(10);

        // Act
        var result = circle.GetArea();

        // Assert
        Assert.Equal(314.15926535897932384626433832795, result);
    }
}