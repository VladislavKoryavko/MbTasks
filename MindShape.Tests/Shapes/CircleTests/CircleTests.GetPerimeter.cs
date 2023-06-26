using MindShape.Lib.Shapes;

namespace MindShape.Tests.Shapes.CircleTests;

public partial class CircleTests
{
    [Fact]
    public void GetPerimeter()
    {
        // Arrange
        var circle = new Circle(10);

        // Act
        var result = circle.GetPerimeter();

        // Assert
        Assert.Equal(62.83185307179586476925286766559, result);
    }
}