using System;

namespace Areas
{
    /// <summary>
    /// Triangle класс представляющий фигуру треугольник
    /// </summary>

    public class Triangle : Figure
    {
        /// <summary>
        /// Катет A
        /// </summary>
        public double LegA { get; set; }

        /// <summary>
        /// Катет B
        /// </summary>
        public double LegB { get; set; }

        /// <summary>
        /// Гипотинуза С
        /// </summary>
        public double HypotenuseC { get; set; }

        /// <summary>
        /// Фигура треугольник
        /// </summary>
        /// <param name="legA">Значение катета A</param>
        /// <param name="legB">Значение катета B</param>
        /// <param name="hypotenuseC">Значение гипотенузы С</param>
        /// <returns>Объект фигуры треугольник</returns>
        public Triangle(double legA, double legB, double hypotenuseC)
        {
            LegA = legA;
            LegB = legB;
            HypotenuseC = hypotenuseC;
        }

        /// <summary>
        /// Метод нахождения площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        protected override double AreaFigure()
        {
            double semiPerimeter = (LegA + LegB + HypotenuseC) / 2;

            if (LegA + LegB <= HypotenuseC || LegA + HypotenuseC <= LegB || LegB + HypotenuseC <= LegA)
            {
                throw new Exception("Треугольник не существует");
            }
            else if (LegA*LegA + LegB*LegB != HypotenuseC*HypotenuseC)
            {
                return Math.Sqrt(semiPerimeter * (semiPerimeter - LegA) * (semiPerimeter - LegB) * (semiPerimeter - HypotenuseC)); //По трём сторонам
            }
            else
            {
                return 0.5 * LegA * LegB; //Прямоугольный треугольник
            }
        }
    }
}
