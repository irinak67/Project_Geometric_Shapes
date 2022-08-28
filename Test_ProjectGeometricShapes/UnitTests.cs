using NUnit.Framework;

namespace Project_Geometric_Shapes.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_of_class_Shape()
        {
            Shape shape = new Shape();
            string result = "A Shape with color of green and filled";
            Assert.AreEqual(result, shape.ToString());
        }
    }
}