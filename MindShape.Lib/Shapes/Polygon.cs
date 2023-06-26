namespace MindShape.Lib.Shapes;

public abstract class Polygon : Shape
{
    private const double ToleranceComparison = 1e-6;

    private List<double> _sides = new();

    public List<double> Sides
    {
        get => _sides;
        set
        {
            if (value.Count != GetNumberSides())
            {
                throw new ArgumentException("Указанно не верное количество сторон", nameof(value));
            }

            if (value.Any(s => s <= 0))
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Сторона многоугольника должна быть больше нуля");
            }

            _sides = new List<double>(value);
        }
    }

    protected Polygon(List<double> sides)
    {
        Sides = sides;
    }

    protected abstract byte GetNumberSides();

    public override double GetPerimeter()
    {
        return Sides.Sum();
    }

    public bool IsEquilateral()
    {
        var firstSide = Sides.First();

        return Sides.All(side => Math.Abs(side - firstSide) < ToleranceComparison);
    }
}