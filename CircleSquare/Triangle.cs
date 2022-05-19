
namespace CalculateSquare
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle
    {
        private double _a;
        private double _b;
        private double _c;
        private double _p;
        
        /// <summary>
        /// Сторона А
        /// </summary>
        public double A
        {
            get => _a;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона должна быть положительным числом");
                _a = value;
            }
        }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double B
        {
            get => _b;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона должна быть положительным числом");
                _b = value;
            }
        }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double C
        {
            get => _c;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона должна быть положительным числом");
                _c = value;
            }
        }

        /// <summary>
        /// Полупериметр
        /// </summary>
        public double P
        {
            get => _p;
            set
            {
                if (value < A || value < B || value < C)
                    throw new ArgumentException("Треульник с такими сторонами невозможен");
                _p = value;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="a">А</param>
        /// <param name="b">B</param>
        /// <param name="c">C</param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            P = (A + B + C) / 2;
        }

        /// <summary>
        /// Расчет площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double Square()
            => Math.Sqrt(P * (P - A) * (P - B) * (P - C));

        /// <summary>
        /// Является ли треугольник правильным
        /// </summary>
        /// <returns>Треугольник правильный?</returns>
        public bool IsRight()
        {
            var sides = new double[3] {A, B, C};
            double temp;
            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (sides[i] < sides[j])
                    {
                        temp = sides[i];
                        sides[i] = sides[j];
                        sides[j] = temp;
                    }
                }
            }
            return sides[0] == Math.Sqrt(Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2));
        }
    }
}
