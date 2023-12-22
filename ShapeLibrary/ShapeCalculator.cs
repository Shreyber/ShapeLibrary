namespace ShapeLibrary
{
    public static class ShapeCalculator
    {
        /// <summary>
        /// Вычисляет площадь фигуры по радиусу
        /// </summary>
        /// <param name="side">Радиус</param>
        /// <returns>Площадь круга</returns>
        public static double CalculateArea(double side)
        {
            var circle = new Circle(side);
            return circle.CalculateArea();
        }

        /// <summary>
        /// Вычисляет площадь фигуры по трем сторонам
        /// </summary>
        /// <param name="sideA">Сторона 1</param>
        /// <param name="sideB">Сторона 2</param>
        /// <param name="sideC">Сторона 3</param>
        /// <returns>Площадь треугольника</returns>
        public static double CalculateArea(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            return triangle.CalculateArea();
        }
    }
}
