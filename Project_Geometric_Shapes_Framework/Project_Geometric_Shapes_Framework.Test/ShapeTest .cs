using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Geometric_Shapes_Framework.Classes;
using System;

namespace Project_Geometric_Shapes_Framework.Test
{
    [TestClass]    
    public class ShapeTest
    {
        public class ShapeTestClass : Shape
        {
            public ShapeTestClass()
            {
            }
            public ShapeTestClass(string Color, bool Fill) : base(Color, Fill)
            {
            }            
        }

        [TestMethod]
        public void Class_Shape_without_argument()
        {

            // arrange
            ShapeTestClass shape = new ShapeTestClass();
            string expected = "A Shape with color of green and filled";            

            // act
            string actual = shape.ToString();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Shape_when_color_is_blue_and_fill_is_false()
        {

            // arrange
            ShapeTestClass shape = new ShapeTestClass("blue", false);
            string expected = "A Shape with color of blue and not filled"; 

            // act
            string actual = shape.ToString();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Shape_when_color_is_grey()
        {

            // arrange
            ShapeTestClass shape = new ShapeTestClass();
            shape.Color = "grey";
            string expected = "A Shape with color of grey and filled";

            // act
            string actual = shape.ToString();

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Class_Shape_when_fill_is_false()
        {

            // arrange
            ShapeTestClass shape = new ShapeTestClass();
            shape.Fill = false;
            string expected = "A Shape with color of green and not filled";

            // act
            string actual = shape.ToString();

            // assert
            Assert.AreEqual(actual, expected);
        }
        
    }
}
