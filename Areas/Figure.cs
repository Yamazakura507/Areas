namespace Areas
{
    /// <summary>
    /// Figure класс представляющий фигуру
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Area { get => AreaFigure(); set => Area = value; }

        /// <summary>
        /// Метод для нахождения площади фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        protected virtual double AreaFigure()
        { 
            return 0;
        }
    }
}
