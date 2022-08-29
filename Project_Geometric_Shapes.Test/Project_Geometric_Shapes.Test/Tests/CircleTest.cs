using Project_Geometric_Shapes.Test.Classes;

namespace Project_Geometric_Shapes.Test.Tests
{
    public class CircleTest
    {
        Circle circle;

        [SetUp]
        public void Setup()
        {
            circle = new Circle();
        }

        [Test]
        public void Test_class_Circle_without_argument()
        {
            string testText = "A Circle with radius = 1, which is a subclass of A Shape with color of green and filled";
            Assert.That(circle.ToString(), Is.EqualTo(testText));
            Assert.AreEqual(3.14, circle.getArea());
            Assert.AreEqual(6.28, circle.getPerimeter());
        }

        [Test]
        public void Test_class_Circle_with_argument()
        {
            circle.Color = "yellow";
            circle.Fill = false;
            circle.Radius = 5.0;
            string testText = "A Circle with radius = 5, which is a subclass of A Shape with color of yellow and not filled";
            Assert.That(circle.ToString(), Is.EqualTo(testText));
        }
        [Test]
        public void Test_class_Circle_get_area_Radius_2()
        {
            circle.Radius = 2.0;
            Assert.AreEqual(12.56d, circle.getArea());

        }
        [Test]
        public void Test_class_Circle_get_perimeter_Radius_8()
        {
            circle.Radius = 8.0;
            Assert.AreEqual(50.24d, circle.getPerimeter());

        }
        [Test]
        public void Test_class_Circle_with_Radius_negative()
        {
            circle.Radius = -3.0;
            Assert.AreEqual(0, circle.getArea());
            Assert.AreEqual(0, circle.getPerimeter());

        }
        [Test]
        public void Test_class_Circle_with_Radius_zero()
        {
            circle.Radius = 0.0;
            Assert.AreEqual(0, circle.getArea());
            Assert.AreEqual(0, circle.getPerimeter());
        }
    }
}