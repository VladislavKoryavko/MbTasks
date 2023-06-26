using MindShape.Lib.Shapes;

namespace MindShape.Tests.Shapes.CircleTests;

public partial class CircleTests
{
    [Fact]
    public void CreateInstance()
    {
        // Arrange
        const double radius = 10;

        // Act
        var result = new Circle(radius);

        // Assert
        Assert.IsType<Circle>(result);
        Assert.Equal(radius, result.Radius);
    }

    [Fact]
    public void CreateInstanceWhenRadiusZero()
    {
        // Act
        var action = () => new Circle(0);

        // Assert
        var exception = Assert.Throws<ArgumentOutOfRangeException>(action);
        Assert.Equal("Радиус должен быть больше нуля (Parameter 'value')", exception.Message);
    }

    [Fact]
    public void CreateInstanceWhenRadiusLessThanZero()
    {
        // Act
        var action = () => new Circle(-12);

        // Assert
        var exception = Assert.Throws<ArgumentOutOfRangeException>(action);
        Assert.Equal("Радиус должен быть больше нуля (Parameter 'value')", exception.Message);
    }
}