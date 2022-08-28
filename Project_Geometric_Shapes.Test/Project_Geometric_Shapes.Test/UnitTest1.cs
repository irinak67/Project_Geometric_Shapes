namespace Project_Geometric_Shapes.Test
{
    [TestFixture]
    public class TestShape : Shape
    {
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_class_Shape_without_argument()
        {
            TestShape shape = new TestShape();
            string testText = "A Shape with color of green and filled";

            Assert.That(shape.ToString(), Is.EqualTo(testText));
        }
        
        [Test]
        public void Test_class_Circle_without_argument()
        {
            Circle circle = new Circle();
            string testText = "A Circle with radius = 1, which is a subclass of A Shape with color of green and filled";
            Assert.That(circle.ToString(), Is.EqualTo(testText));
        }
        [Test]
        public void Test_class_Circle_get_area()
        {
            Circle circle = new Circle();            
            Assert.AreEqual(3.14, circle.getArea());

        }
        [Test]
        public void Test_class_Circle_get_perimeter()
        {
            Circle circle = new Circle();
            Assert.AreEqual(6.28, circle.getPerimeter());

        }
        [Test]
        public void Test_class_Rectangle_without_argument()
        {
            Rectangle rectangle = new Rectangle();
            string testText = "A Rectangle with width = 1 and length = 1, which is a subclass of A Shape with color of green and filled";
            Assert.That(rectangle.ToString(), Is.EqualTo(testText));
        }
        [Test]
        public void Test_class_Rectangle_get_area()
        {
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(1.00, rectangle.getArea());
        }
        [Test]
        public void Test_class_Rectangle_get_perimeter()
        {
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(4.00, rectangle.getPerimeter());
        }
    }
}