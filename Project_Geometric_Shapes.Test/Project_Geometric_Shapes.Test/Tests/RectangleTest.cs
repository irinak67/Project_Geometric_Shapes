using Project_Geometric_Shapes.Test.Classes;

namespace Project_Geometric_Shapes.Test.Tests;
public class RectangleTest
{
    Rectangle rectangle;

    [SetUp]
    public void Setup()
    {
        rectangle = new Rectangle();
    }

    [Test]
    public void Test_class_Rectangle_without_argument()
    {
        string testText = "A Rectangle with width = 1 and length = 1, which is a subclass of A Shape with color of green and filled";
        Assert.That(rectangle.ToString(), Is.EqualTo(testText));
    }

    [Test]
    public void Test_class_Rectangle_get_area_without_argument()
    {
        Assert.That(rectangle.getArea(), Is.EqualTo(1));
    }

    [Test]
    public void Test_class_Rectangle_get_perimeter_without_argument()
    {
        Assert.That(rectangle.getPerimeter(), Is.EqualTo(4.00));
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
    public void Test_class_Rectangle_get_area_when_Width_is_8_and_Length_is_11()
    {
        rectangle.Width = 8.0;
        rectangle.Length = 11.0;
        Assert.That(rectangle.getArea(), Is.EqualTo(88.00));
    }

    [Test]
    public void Test_class_Rectangle_get_perimeter_when_Width_is_5_and_Length_is_7()
    {
        rectangle.Width = 5.0;
        rectangle.Length = 7.0;
        Assert.That(rectangle.getPerimeter(), Is.EqualTo(24.00));
    }

    [Test]
    public void Test_class_Rectangle_get_area_when_Length_is_negative()
    {
        rectangle.Width = 5.0;
        rectangle.Length = -16.0;
        Assert.That(rectangle.getArea(), Is.EqualTo(-1));
    }

    [Test]
    public void Test_class_Rectangle_get_perimeter_when_Length_is_negative()
    {
        rectangle.Width = 5.0;
        rectangle.Length = -6.0;            
        Assert.That(rectangle.getPerimeter(), Is.EqualTo(-1));
    }
    
    [Test]
    public void Test_class_Rectangle_get_area_when_Width_is_negative()
    {
        rectangle.Width = -9.0;
        rectangle.Length = 3.0;
        Assert.That(rectangle.getArea(), Is.EqualTo(-1));
    }

    [Test]
    public void Test_class_Rectangle_get_perimeter_when_Width_is_negative()
    {
        rectangle.Width = -19.0;
        rectangle.Length = 4.0;
        Assert.That(rectangle.getPerimeter(), Is.EqualTo(-1));
    }

    [Test]
    public void Test_class_Rectangle_get_area_when_Width_and_Length_are_negative()
    {
        rectangle.Width = -55.0;
        rectangle.Length = -11.0;
        Assert.That(rectangle.getArea(), Is.EqualTo(-1));
    }

    [Test]
    public void Test_class_Rectangle_get_perimeter_when_Width_and_Length_are_negative()
    {
        rectangle.Width = -89.0;
        rectangle.Length = -5.0;
        Assert.That(rectangle.getPerimeter(), Is.EqualTo(-1));
    }

    [Test]
    public void Test_class_Rectangle_get_area_when_Width_is_zero()
    {
        rectangle.Width = 0;
        rectangle.Length = 41.0;
        Assert.That(rectangle.getArea(), Is.EqualTo(0));
    }

    [Test]
    public void Test_class_Rectangle_get_perimeter_when_Width_is_zero()
    {
        rectangle.Width = 0;
        rectangle.Length = 25.0;
        Assert.That(rectangle.getPerimeter(), Is.EqualTo(0));
    }

    [Test]
    public void Test_class_Rectangle_get_area_when_Length_is_zero()
    {
        rectangle.Width = 15.0;
        rectangle.Length = 0;
        Assert.That(rectangle.getArea(), Is.EqualTo(0));
    }

    [Test]
    public void Test_class_Rectangle_get_perimeter_when_Length_is_zero()
    {
        rectangle.Width = 9.0;
        rectangle.Length = 0;
        Assert.That(rectangle.getPerimeter(), Is.EqualTo(0));
    }

    [Test]
    public void Test_class_Rectangle_get_area_when_Width_and_Length_are_zero()
    {
        rectangle.Width = 0;
        rectangle.Length = 0;
        Assert.That(rectangle.getArea(), Is.EqualTo(0));
    }

    [Test]
    public void Test_class_Rectangle_get_perimeter_when_Width_and_Length_are_zero()
    {
        rectangle.Width = 0;
        rectangle.Length = 0;
        Assert.That(rectangle.getPerimeter(), Is.EqualTo(0));
    }
}