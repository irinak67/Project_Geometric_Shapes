using Project_Geometric_Shapes.Test.Classes;

namespace Project_Geometric_Shapes.Test.Tests;
public class CircleTest
{
    Circle circle;

    [SetUp]
    public void Setup()
    {
        circle = new Circle();
    }

    [Test]
    public void Test_class_Circle_without_argument()
    {
        string testText = "A Circle with radius = 1, which is a subclass of A Shape with color of green and filled";
        Assert.That(circle.ToString(), Is.EqualTo(testText));
    }

    [Test]
    public void Test_class_Circle_get_area_without_argument()
    {
        Assert.That(circle.getArea(), Is.EqualTo(3.14));
    }

    [Test]
    public void Test_class_Circle_get_perimeter_without_argument()
    {
        Assert.That(circle.getPerimeter(), Is.EqualTo(6.28));
    }

    [Test]
    public void Test_class_Circle_with_argument()
    {
        circle.Color = "yellow";
        circle.Fill = false;
        circle.Radius = 5.0;
        string testText = "A Circle with radius = 5, which is a subclass of A Shape with color of yellow and not filled";
        Assert.That(circle.ToString(), Is.EqualTo(testText));
    }

    [Test]
    public void Test_class_Circle_get_area_when_Radius_is_2()
    {
        circle.Radius = 2.0;
        Assert.That(circle.getArea(), Is.EqualTo(12.56d));
    }

    [Test]
    public void Test_class_Circle_get_perimeter_when_Radius_is_8()
    {
        circle.Radius = 8.0;
        Assert.That(circle.getPerimeter(), Is.EqualTo(50.24d));
    }

    [Test]
    public void Test_class_Circle_get_area_when_Radius_is_negative()
    {
        circle.Radius = -3.0;
        Assert.That(circle.getArea(), Is.EqualTo(-1));
    }

    [Test]
    public void Test_class_Circle_get_perimeter_when_Radius_is_negative()
    {
        circle.Radius = -75.0;
        Assert.That(circle.getPerimeter(), Is.EqualTo(-1));
    }

    [Test]
    public void Test_class_Circle_get_area_when_Radius_is_zero()
    {
        circle.Radius = 0.0;
        Assert.That(circle.getArea(), Is.EqualTo(0));
    }

    [Test]
    public void Test_class_Circle_get_perimeter_when_Radius_is_zero()
    {
        circle.Radius = 0.0;
        Assert.That(circle.getPerimeter(), Is.EqualTo(0));
    }
}