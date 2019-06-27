using DesignPatterns.Factory;
using NUnit.Framework;

namespace DesignPatternsTest
{
    public class Factory
    {
        private readonly ShapeFactory shapeFactory = new ShapeFactory();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateCircle()
        {
            IShape circle = shapeFactory.getShape(ShapeType.Circle);
            circle.Draw();

            Assert.IsInstanceOf<Circle>(circle);
        }

        [Test]
        public void CreateSquare()
        {
            IShape square = shapeFactory.getShape(ShapeType.Square);
            square.Draw();

            Assert.IsInstanceOf<Square>(square);
        }

        [Test]
        public void CreateRectangle()
        {
            IShape rectangle = shapeFactory.getShape(ShapeType.Rectangle);
            rectangle.Draw();

            Assert.IsInstanceOf<Rectangle>(rectangle);
        }
        
    }
}