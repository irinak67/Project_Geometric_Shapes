using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Geometric_Shapes_Framework.Classes;

namespace Project_Geometric_Shapes_Framework.Test
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void Class_Rectangle_without_argument()
        {
            // arrange
            Rectangle rectangle = new Rectangle();
            string expected = "A Rectangle with width = 1 and length = 1, which is a subclass of A Shape with color of green and filled";

            // act
            string actual = rectangle.ToString();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_area_without_argument()
        {
            // arrange
            Rectangle rectangle = new Rectangle();
            double expected = 1.00;

            // act
            double actual = rectangle.getArea();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_perimeter_without_argument()
        {
            // arrange
            Rectangle rectangle = new Rectangle();
            double expected = 4.00;

            // act
            double actual = rectangle.getPerimeter();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_with_argument()
        {
            // arrange
            Rectangle rectangle = new Rectangle(10.0, 15.0, "red", false);
            rectangle.Width = 10.0;
            rectangle.Length = 15.0;
            string expected = "A Rectangle with width = 10 and length = 15, which is a subclass of A Shape with color of red and not filled";

            // act
            string actual = rectangle.ToString();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_area_when_Width_is_5_and_Length_is_7()
        {
            // arrange
            Rectangle rectangle = new Rectangle(8.0, 11.0);
            double expected = 88.00;

            // act
            double actual = rectangle.getArea();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_perimeter_when_Width_is_5_and_Length_is_7()
        {
            // arrange
            Rectangle rectangle = new Rectangle(5.0, 7.0);
            double expected = 24.00;

            // act
            double actual = rectangle.getPerimeter();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_area_when_Length_is_negative()
        {
            // arrange
            Rectangle rectangle = new Rectangle(5.0, -16.0);
            double expected = 0;

            // act
            double actual = rectangle.getArea();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_perimeter_when_Length_is_negative()
        {
            // arrange
            Rectangle rectangle = new Rectangle(5.0, -6.0);
            double expected = 0;

            // act
            double actual = rectangle.getPerimeter();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_area_when_Width_is_negative()
        {
            // arrange
            Rectangle rectangle = new Rectangle(-9.0, 3.0);
            double expected = 0;

            // act
            double actual = rectangle.getArea();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_perimeter_when_Width_is_negative()
        {
            // arrange
            Rectangle rectangle = new Rectangle(-29.0, 4.0);
            double expected = 0;

            // act
            double actual = rectangle.getPerimeter();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_area_when_Width_and_Length_are_negative()
        {
            // arrange
            Rectangle rectangle = new Rectangle(-55.0, -11.0);
            double expected = 0;

            // act
            double actual = rectangle.getArea();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_perimeter_when_Width_and_Length_are_negative()
        {
            // arrange
            Rectangle rectangle = new Rectangle(-89.0, -5.0);
            double expected = 0;

            // act
            double actual = rectangle.getPerimeter();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_area_when_Width_is_zero()
        {
            // arrange
            Rectangle rectangle = new Rectangle(0, 41.0);
            double expected = 0;

            // act
            double actual = rectangle.getArea();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_perimeter_when_Width_is_zero()
        {
            // arrange
            Rectangle rectangle = new Rectangle(0, 25.0);
            double expected = 0;

            // act
            double actual = rectangle.getPerimeter();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_area_when_Length_is_zero()
        {
            // arrange
            Rectangle rectangle = new Rectangle(15.0, 0);
            double expected = 0;

            // act
            double actual = rectangle.getArea();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_perimeter_when_Length_is_zero()
        {
            // arrange
            Rectangle rectangle = new Rectangle(9.0, 0);
            double expected = 0;

            // act
            double actual = rectangle.getPerimeter();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_area_when_Width_and_Length_are_zero()
        {
            // arrange
            Rectangle rectangle = new Rectangle(0, 0);
            double expected = 0;

            // act
            double actual = rectangle.getArea();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Rectangle_get_perimeter_when_Width_and_Length_are_zero()
        {
            // arrange
            Rectangle rectangle = new Rectangle(0, 0);
            double expected = 0;

            // act
            double actual = rectangle.getPerimeter();

            // assert
            Assert.AreEqual(actual, expected);
        }
    }
}
