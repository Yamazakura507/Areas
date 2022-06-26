using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    /// <summary>
    /// Circle класс представляющий фигуру круг
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Фигура круг
        /// </summary>
        /// <param name="radius">Значение радиуса круга</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Метод нахождение площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        protected override double AreaFigure()
        {
            if (Radius <= 0)
            {
                throw new Exception("Круг не существует");
            }

            return Math.PI * Radius * Radius;
        }
    }
}
