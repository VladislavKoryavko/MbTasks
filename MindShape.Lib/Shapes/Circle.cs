namespace MindShape.Lib.Shapes;

public class Circle : Shape
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Радиус должен быть больше нуля");
            }

            _radius = value;
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    private static double GetCircumferenceByRadius(double radius) => 2 * Math.PI * radius;

    public override double GetPerimeter()
    {
        return GetCircumferenceByRadius(Radius);
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}