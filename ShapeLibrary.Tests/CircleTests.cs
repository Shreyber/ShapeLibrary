namespace ShapeLibrary.Tests
{
    public class CircleTests
    {
        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(double.MinValue)]
        [TestCase(double.NegativeInfinity)]
        [TestCase(double.NegativeZero)]
        [TestCase(double.NaN)]

        public void TryCreateNonPositiveRadiusCircleTest(double r)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { new Circle(r); });
        }

        [Test]
        [TestCase(1, Math.PI)]
        [TestCase(1/Math.PI, 1/Math.PI)]
        [TestCase(double.MaxValue, double.PositiveInfinity)]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity)]
        public void CalculateAreaTest(double r, double result)
        {
            var circle = new Circle(r);
            Assert.That(circle.CalculateArea(), Is.EqualTo(result));
        }
    }
}