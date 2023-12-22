namespace ShapeLibrary
{
    public class Circle: IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0 || double.IsNaN(radius))
                throw new ArgumentOutOfRangeException("Радиус круга должен быть больше нуля.");

            Radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга по радиусу
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle: IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0
                || double.IsNaN(sideA) || double.IsNaN(sideB) || double.IsNaN(sideC))
                throw new ArgumentOutOfRangeException("Стороны треугольника должны быть больше нуля.");

            if (sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideA + sideB)
                throw new ArgumentException("Треугольник с заданными сторонами не существует.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Вычисляет площадь треугольника по трем сторонам
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double CalculateArea()
        {
            // Вычисляем полупериметр
            double p = (SideA + SideB + SideC) / 2;
            // Формула Герона
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        
        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightAngled()
        {
            return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2)
                || Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2)
                || Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2);
        }
    }
}