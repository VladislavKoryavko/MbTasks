namespace MindShape.Lib.Shapes;

/// <summary>
/// Абстрактный класс, наследник базового класса фигура,
/// определяет фигуры, которые имеют более двух прямолинейных сторон
/// </summary>
public abstract class Polygon : Shape
{
    /// <summary>
    /// Допустимое отклонение в операциях сравнения чисел с плавающей точкой
    /// </summary>
    private const double ToleranceComparison = 1e-6;

    /// <summary>
    /// Список длин сторон полигона
    /// </summary>
    private List<double> _sides = new();

    /// <summary>
    /// Свойство для работы со списком сторон полигона
    /// </summary>
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

    /// <summary>
    /// Защищённый конструктор, используется классами наследниками 
    /// </summary>
    /// <param name="sides"></param>
    protected Polygon(List<double> sides)
    {
        Sides = sides;
    }

    /// <summary>
    /// Абстрактный метод, отвечает за предоставление количества сторон в классах наследниках
    /// </summary>
    /// <returns></returns>
    protected abstract byte GetNumberSides();

    /// <summary>
    /// Метод возвращающий периметр полигона
    /// </summary>
    /// <returns></returns>
    public override double GetPerimeter()
    {
        return Sides.Sum();
    }

    /// <summary>
    /// Данный метод определяет является ли полигон равносторонним
    /// </summary>
    /// <returns></returns>
    public bool IsEquilateral()
    {
        var firstSide = Sides.First();

        return Sides.All(side => Math.Abs(side - firstSide) < ToleranceComparison);
    }
}