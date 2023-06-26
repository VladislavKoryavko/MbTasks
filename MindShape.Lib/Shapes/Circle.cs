namespace MindShape.Lib.Shapes;

/// <summary>
/// Класс круг, наследник базового класса фигура
/// </summary>
public class Circle : Shape
{
    /// <summary>
    /// Поле хранящее радиус круга
    /// </summary>
    private double _radius;

    /// <summary>
    /// Свойство отвечающее за работу с полем радиуса
    /// </summary>
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

    /// <summary>
    /// Публичный конструктор для круга
    /// </summary>
    /// <param name="radius"> Радиус создаваемого круга </param>
    public Circle(double radius)
    {
        Radius = radius;
    }

    /// <summary>
    /// Метод рассчитывающий длину окружности по радиусу круга
    /// </summary>
    /// <param name="radius"></param>
    /// <returns></returns>
    private static double GetCircumferenceByRadius(double radius) => 2 * Math.PI * radius;

    /// <summary>
    /// Метод предоставляющий периметр круга
    /// </summary>
    /// <returns></returns>
    public override double GetPerimeter()
    {
        return GetCircumferenceByRadius(Radius);
    }

    /// <summary>
    /// Метод возвращающий площадь круга
    /// </summary>
    /// <returns></returns>
    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}