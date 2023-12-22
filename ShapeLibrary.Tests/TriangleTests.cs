namespace ShapeLibrary.Tests
{
    public class TriangleTests
    {
        [Test]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(double.MinValue, 1, 1)]
        [TestCase(double.NegativeInfinity, 1, 1)]
        [TestCase(double.NegativeZero, 1, 1)]
        [TestCase(double.NaN, 1, 1)]

        public void TryCreateNonPositiveSidesTriangleTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { new Triangle(a, b, c); });
        }

        [Test]
        [TestCase(20, 10, 10)]
        [TestCase(5, 15, 5)]
        [TestCase(1, 1, 10)]
        [TestCase(1.99999999999, 0.00000000001, 2)]
        [TestCase(double.MaxValue, 5, 5)]
        [TestCase(double.PositiveInfinity, 1, 1)]
        public void TryCreateWrongTriangleTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => { new Triangle(a, b, c); });
        }

        [Test]
        [TestCase(3, 4, 5, 6)]
        [TestCase(10, 10, 12, 48)]
        [TestCase(1, 3, 3, 1.479019945774904)]
        public void CalculateAreaTest(double a, double b, double c, double result)
        {
            var triange = new Triangle(a, b, c);
            Assert.That(triange.CalculateArea(), Is.EqualTo(result));
        }

        [Test]
        [TestCase(3, 4, 5, true)]
        [TestCase(2, 3, 4, false)]
        [TestCase(5, 12, 13, true)]
        [TestCase(10, 10, 5, false)]
        public void IsRightAngledTest(double a, double b, double c, bool result)
        {
            var triange = new Triangle(a, b, c);
            Assert.That(triange.IsRightAngled(), Is.EqualTo(result));
        }
    }
}