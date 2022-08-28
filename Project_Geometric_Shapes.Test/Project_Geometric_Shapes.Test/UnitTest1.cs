namespace Project_Geometric_Shapes.Test
{
    [TestFixture]
    public class TestShape : Shape
    {
    }
    public class Tests
    {
        TestShape shape;
        Circle circle;
        Rectangle rectangle;

        [SetUp]
        public void Setup()
        {
            shape = new TestShape();
            circle = new Circle();
            rectangle = new Rectangle();
        }

        [Test]
        public void Test_class_Shape_without_argument()
        {           
            string testText = "A Shape with color of green and filled";
            Assert.That(shape.ToString(), Is.EqualTo(testText));
        }
        [Test]
        public void Test_class_Shape_color_blue_fill_false()
        {
            shape.Color = "blue";
            shape.Fill = false;
            string testText = "A Shape with color of blue and not filled";
            Assert.That(shape.ToString(), Is.EqualTo(testText));
        }
        [Test]
        public void Test_class_Circle_without_argument()
        {
            string testText = "A Circle with radius = 1, which is a subclass of A Shape with color of green and filled";
            Assert.That(circle.ToString(), Is.EqualTo(testText));
        }
        
        [Test]
        public void Test_class_Circle_get_area()
        {       
            Assert.AreEqual(3.14, circle.getArea());

        }
        [Test]
        public void Test_class_Circle_get_area_Radius_2()
        {
            circle.Radius = 2.0;
            Assert.AreEqual(12.56d, circle.getArea());

        }
        [Test]
        public void Test_class_Circle_get_perimeter()
        {
            Assert.AreEqual(6.28, circle.getPerimeter());

        }
        [Test]
        public void Test_class_Circle_get_perimeter_Radius_8()
        {
            circle.Radius = 8.0;
            Assert.AreEqual(50.24d, circle.getPerimeter());

        }
        [Test]
        public void Test_class_Rectangle_without_argument()
        {
            string testText = "A Rectangle with width = 1 and length = 1, which is a subclass of A Shape with color of green and filled";
            Assert.That(rectangle.ToString(), Is.EqualTo(testText));
        }
        [Test]
        public void Test_class_Rectangle_get_area()
        {
            Assert.AreEqual(1.00, rectangle.getArea());
        }
        [Test]
        public void Test_class_Rectangle_get_area_Width_2_Length_3()
        {
            rectangle.Width = 2.0;
            rectangle.Length = 3.0;
            Assert.AreEqual(6.00, rectangle.getArea());

        }
        [Test]
        public void Test_class_Rectangle_get_perimeter()
        {
            Assert.AreEqual(4.00, rectangle.getPerimeter());
        }
        [Test]
        public void Test_class_Rectangle_get_perimeter_Width_5_Length_7()
        {
            rectangle.Width = 5.0;
            rectangle.Length = 7.0;
            Assert.AreEqual(24.00, rectangle.getPerimeter());

        }
    }
}