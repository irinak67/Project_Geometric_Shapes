using Project_Geometric_Shapes.Test.Classes;

namespace Project_Geometric_Shapes.Test.Tests
{

    public class RectangleTest
    {
        Rectangle rectangle;

        [SetUp]
        public void Setup()
        {
            rectangle = new Rectangle();
        }

        [Test]
        public void Test_class_Rectangle_with_argument()
        {
            rectangle.Color = "red";
            rectangle.Fill = false;
            rectangle.Width = 10.0;
            rectangle.Length = 15.0;
            string testText = "A Rectangle with width = 10 and length = 15, which is a subclass of A Shape with color of red and not filled";
            Assert.That(rectangle.ToString(), Is.EqualTo(testText));
        }
        [Test]
        public void Test_class_Rectangle_without_argument()
        {
            string testText = "A Rectangle with width = 1 and length = 1, which is a subclass of A Shape with color of green and filled";
            Assert.That(rectangle.ToString(), Is.EqualTo(testText));
            Assert.AreEqual(1.00, rectangle.getArea());
            Assert.AreEqual(4.00, rectangle.getPerimeter());
        }
        [Test]
        public void Test_class_Rectangle_get_perimeter_Width_5_Length_7()
        {
            rectangle.Width = 5.0;
            rectangle.Length = 7.0;
            Assert.AreEqual(24.00, rectangle.getPerimeter());
        }
        [Test]
        public void Test_class_Rectangle_get_perimeter_Length_negative()
        {
            rectangle.Width = 5.0;
            rectangle.Length = -6.0;
            Assert.AreEqual(0, rectangle.getArea());
            Assert.AreEqual(0, rectangle.getPerimeter());
        }
        [Test]
        public void Test_class_Rectangle_get_area_Width_negative()
        {
            rectangle.Width = -9.0;
            rectangle.Length = 3.0;
            Assert.AreEqual(0, rectangle.getArea());
            Assert.AreEqual(0, rectangle.getPerimeter());

        }
        [Test]
        public void Test_class_Rectangle_get_area_Width_and_Length_negative()
        {
            rectangle.Width = -55.0;
            rectangle.Length = -11.0;
            Assert.AreEqual(0, rectangle.getArea());
            Assert.AreEqual(0, rectangle.getPerimeter());

        }
    }
}