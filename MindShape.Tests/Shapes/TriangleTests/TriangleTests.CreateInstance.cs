using MindShape.Lib.Shapes;

namespace MindShape.Tests.Shapes.TriangleTests;

public partial class TriangleTests
{
    [Fact]
    public void CreateInstance()
    {
        // Arrange
        var sides = new List<double> { 1, 2, 3 };

        // Act
        var result = new Triangle(sides);

        // Assert
        Assert.IsType<Triangle>(result);
        Assert.Equal(sides, result.Sides);
    }

    [Fact]
    public void CreateInstanceWhenNumberOfSidesNotEqualThree()
    {
        // Arrange
        var sides = new List<double> { 1, 2 };

        // Act
        var action = () => new Triangle(sides);

        // Assert
        var exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Указанно не верное количество сторон (Parameter 'value')", exception.Message);
    }

    [Fact]
    public void CreateInstanceWhenSizeOfSideZero()
    {
        // Arrange
        var sides = new List<double> { 1, 0, 3 };

        // Act
        var action = () => new Triangle(sides);

        // Assert
        var exception = Assert.Throws<ArgumentOutOfRangeException>(action);
        Assert.Equal("Сторона многоугольника должна быть больше нуля (Parameter 'value')", exception.Message);
    }

    [Fact]
    public void CreateInstanceWhenSizeOfSidesLessThanZero()
    {
        // Arrange
        var sides = new List<double> { 1, 2, -1 };

        // Act
        var action = () => new Triangle(sides);

        // Assert
        var exception = Assert.Throws<ArgumentOutOfRangeException>(action);
        Assert.Equal("Сторона многоугольника должна быть больше нуля (Parameter 'value')", exception.Message);
    }
}