namespace CalculateSquare
{
    /// <summary>
    /// Геометрическая фигура
    /// </summary>
    public class FigureBuilder
    {
        public Circle Build (double r)
        => new Circle (r);

        public Triangle Build (double a, double b, double c)
            => new Triangle (a, b, c);
    }
}
