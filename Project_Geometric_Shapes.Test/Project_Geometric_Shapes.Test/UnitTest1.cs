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
        //[Test]
        //public void Test_class_Shape_with_argument()
        //{
        //    TestShape shape = new TestShape();

        //    //string color = "red";
        //    //bool fill = false;
        //    //shape.Shape("red", false);
        //    string testText = "A Shape with color of red and not filled";

        //    Assert.That(shape.ToString(), Is.EqualTo(testText));
        //}

        [Test]
        public void Test_class_Circle_without_argument()
        {
            Circle circle = new Circle();
            string testText = "A Circle with radius = 1, which is a subclass of A Shape with color of green and filled";
            Assert.That(circle.ToString(), Is.EqualTo(testText));
        }

        [Test]
        public void Test_class_Rectangle_without_argument()
        {
            Rectangle rectangle = new Rectangle();
            string testText = "A Rectangle with width = 1 and length = 1, which is a subclass of A Shape with color of green and filled";
            Assert.That(rectangle.ToString(), Is.EqualTo(testText));
        }
    }
}