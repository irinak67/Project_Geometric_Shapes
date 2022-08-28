using Project_Geometric_Shapes.Test.Classes;

namespace Project_Geometric_Shapes.Test.Tests
{
    [TestFixture]
    public class ShapeTestClass : Shape
    {
    }
    public class ShapeTest
    {
        ShapeTestClass shape;

        [SetUp]
        public void Setup()
        {
            shape = new ShapeTestClass();
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

    }
}