namespace MindShape.Lib.Shapes;

/// <summary>
/// Базовый абстрактный класс для геометрических фигур
/// </summary>
public abstract class Shape
{
    /// <summary>
    /// Метод возвращающий площадь фигуры
    /// </summary>
    /// <returns></returns>
    public abstract double GetArea();

    /// <summary>
    /// Метод возвращающий периметр фигуры
    /// </summary>
    /// <returns></returns>
    public abstract double GetPerimeter();
}