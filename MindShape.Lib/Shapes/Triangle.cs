namespace MindShape.Lib.Shapes;

/// <summary>
/// Класс треугольник, наследник класса полигон
/// </summary>
public class Triangle : Polygon
{
    /// <summary>
    /// Допустимое отклонение в операциях сравнения чисел с плавающей точкой
    /// </summary>
    private const double ToleranceComparison = 1e-6;

    /// <summary>
    /// Публичный конструктор
    /// </summary>
    /// <param name="sides"> Список сторон треугольника </param>
    public Triangle(List<double> sides) : base(sides) { }

    /// <summary>
    /// Метод возвращающий количество сторон треугольника 
    /// </summary>
    /// <returns></returns>
    protected override byte GetNumberSides() => 3;

    /// <summary>
    /// Метод возвращающий площадь треугольника
    /// </summary>
    /// <returns></returns>
    public override double GetArea()
    {
        var halfPerimeter = GetPerimeter() / 2;
        return Math.Sqrt(halfPerimeter * Sides.Aggregate((a, b) => a * (b - halfPerimeter)));
    }

    /// <summary>
    /// Данный метод определяет является ли треугольник прямоугольным
    /// </summary>
    /// <returns></returns>
    public bool IsRectangular()
    {
        return Math.Abs(Math.Pow(Sides.Max(), 2) * 2 - Sides.Select(s => s * s).Sum()) < ToleranceComparison;
    }
}