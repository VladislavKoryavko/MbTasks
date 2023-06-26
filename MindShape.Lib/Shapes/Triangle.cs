namespace MindShape.Lib.Shapes;

public class Triangle : Polygon
{
    private const double ToleranceComparison = 1e-6;

    public Triangle(List<double> sides) : base(sides) { }

    protected override byte GetNumberSides() => 3;

    public override double GetArea()
    {
        var halfPerimeter = GetPerimeter() / 2;
        return Math.Sqrt(halfPerimeter * Sides.Aggregate((a, b) => a * (b - halfPerimeter)));
    }

    public bool IsRectangular()
    {
        return Math.Abs(Math.Pow(Sides.Max(), 2) * 2 - Sides.Select(s => s * s).Sum()) < ToleranceComparison;
    }
}