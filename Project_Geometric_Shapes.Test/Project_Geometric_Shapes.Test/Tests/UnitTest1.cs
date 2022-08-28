using Project_Geometric_Shapes.Test.Classes;

namespace Project_Geometric_Shapes.Test.Tests
{
    [TestFixture]
    public class TestShape : Shape
    {
    }
    public class Tests
    {
        TestShape shape1;
        Circle circle1;
        Rectangle rectangle1;

        [SetUp]
        public void Setup()
        {
            shape1 = new TestShape();
            circle1 = new Circle();
            rectangle1 = new Rectangle();
        }

        [Test]
        public void Test_class_Shape_without_argument()
        {
            string testText = "A Shape with color of green and filled";
            Assert.That(shape1.ToString(), Is.EqualTo(testText));
        }
        [Test]
        public void Test_class_Shape_color_blue_fill_false()
        {
            shape1.Color = "blue";
            shape1.Fill = false;
            string testText = "A Shape with color of blue and not filled";
            Assert.That(shape1.ToString(), Is.EqualTo(testText));
        }
        [Test]
        public void Test_class_Circle_without_argument()
        {
            string testText = "A Circle with radius = 1, which is a subclass of A Shape with color of green and filled";
            Assert.That(circle1.ToString(), Is.EqualTo(testText));
        }

        [Test]
        public void Test_class_Circle_get_area()
        {
            Assert.AreEqual(3.14, circle1.getArea());

        }
        [Test]
        public void Test_class_Circle_get_area_Radius_2()
        {
            circle1.Radius = 2.0;
            Assert.AreEqual(12.56d, circle1.getArea());

        }
        [Test]
        public void Test_class_Circle_get_area_Radius_negative()
        {
            circle1.Radius = -3.0;
            Assert.AreEqual(0, circle1.getArea());

        }
        [Test]
        public void Test_class_Circle_get_perimeter()
        {
            Assert.AreEqual(6.28, circle1.getPerimeter());

        }
        [Test]
        public void Test_class_Circle_get_perimeter_Radius_8()
        {
            circle1.Radius = 8.0;
            Assert.AreEqual(50.24d, circle1.getPerimeter());

        }
        [Test]
        public void Test_class_Circle_get_perimeter_Radius_negative()
        {
            circle1.Radius = -15.0;
            Assert.AreEqual(0, circle1.getPerimeter());

        }
        [Test]
        public void Test_class_Rectangle_without_argument()
        {
            string testText = "A Rectangle with width = 1 and length = 1, which is a subclass of A Shape with color of green and filled";
            Assert.That(rectangle1.ToString(), Is.EqualTo(testText));
        }
        [Test]
        public void Test_class_Rectangle_get_area()
        {
            Assert.AreEqual(1.00, rectangle1.getArea());
        }
        [Test]
        public void Test_class_Rectangle_get_area_Width_2_Length_3()
        {
            rectangle1.Width = 2.0;
            rectangle1.Length = 3.0;
            Assert.AreEqual(6.00, rectangle1.getArea());

        }
        [Test]
        public void Test_class_Rectangle_get_area_Width_negative_Length_3()
        {
            rectangle1.Width = -9.0;
            rectangle1.Length = 3.0;
            Assert.AreEqual(0, rectangle1.getArea());

        }
        [Test]
        public void Test_class_Rectangle_get_perimeter()
        {
            Assert.AreEqual(4.00, rectangle1.getPerimeter());
        }
        [Test]
        public void Test_class_Rectangle_get_perimeter_Width_5_Length_7()
        {
            rectangle1.Width = 5.0;
            rectangle1.Length = 7.0;
            Assert.AreEqual(24.00, rectangle1.getPerimeter());

        }
        [Test]
        public void Test_class_Rectangle_get_perimeter_Width_5_Length_negative()
        {
            rectangle1.Width = 5.0;
            rectangle1.Length = -6.0;
            Assert.AreEqual(0, rectangle1.getPerimeter());

        }
    }
}