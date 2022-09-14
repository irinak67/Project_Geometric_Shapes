using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Geometric_Shapes_Framework.Classes;

namespace Project_Geometric_Shapes_Framework.Test
{
    [TestClass()]
    public class CircleTest
    {

        [TestMethod()]
        public void Class_Circle_without_argument()
        {

            // arrange
            Circle circle = new Circle();
            string expected = "A Circle with radius = 1, which is a subclass of A Shape with color of green and filled";

            // act
            string actual = circle.ToString();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Class_Circle_get_area_without_argument()
        {

            // arrange
            Circle circle = new Circle();
            double expected = 3.14;

            // act
            double actual = circle.getArea();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Class_Circle_get_perimeter_without_argument()
        {

            // arrange
            Circle circle = new Circle();
            double expected = 6.28;

            // act
            double actual = circle.getPerimeter();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Class_Circle_with_argument()
        {

            // arrange
            Circle circle = new Circle(5.0, "yellow", false );
            circle.Radius = 5;
            string expected = "A Circle with radius = 5, which is a subclass of A Shape with color of yellow and not filled";

            // act
            string actual = circle.ToString();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Class_Circle_get_area_when_Radius_is_2()
        {

            // arrange
            Circle circle = new Circle(2.0);
            double expected = 12.56d;

            // act
            double actual = circle.getArea();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Class_Circle_get_perimeter_when_Radius_is_8()
        {

            // arrange
            Circle circle = new Circle(8.0);
            double expected = 50.24d;

            // act
            double actual = circle.getPerimeter();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Class_Circle_get_area_when_Radius_is_negative()
        {

            // arrange
            Circle circle = new Circle(-3.0);
            double expected = -1;

            // act
            double actual = circle.getArea();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Class_Circle_get_perimeter_when_Radius_is_negative()
        {

            // arrange
            Circle circle = new Circle(-75.0);
            double expected = -1;

            // act
            double actual = circle.getPerimeter();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Class_Circle_get_area_when_Radius_is_zero()
        {

            // arrange
            Circle circle = new Circle(0.0);
            double expected = 0;

            // act
            double actual = circle.getArea();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Class_Circle_get_perimeter_when_Radius_is_zero()
        {

            // arrange
            Circle circle = new Circle(0.0);
            double expected = 0;

            // act
            double actual = circle.getPerimeter();

            // assert
            Assert.AreEqual(actual, expected);
        }
    }
}
