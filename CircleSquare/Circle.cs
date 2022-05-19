namespace CalculateSquare
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle
    {
        private double _radius;

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Радиус должен быть положительным числом");
                _radius = value;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle (double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Расчет площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double Square()
             => Math.Pow(Radius, 2) * Math.PI;
    }
}