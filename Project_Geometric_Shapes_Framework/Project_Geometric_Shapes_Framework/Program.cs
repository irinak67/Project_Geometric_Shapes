using Project_Geometric_Shapes_Framework.Classes;
using System;

namespace Project_Geometric_Shapes_Framework;
class Program
{
    class ShapeTestClass: Shape 
    { 
    }
    static void Main(string[] args)
    {
        ShapeTestClass shape = new ShapeTestClass();
        Circle circle = new Circle();
        Rectangle rect = new Rectangle();

        //Shape
        Console.WriteLine(shape.ToString());
        shape.Color = "red";
        shape.Fill = true;
        Console.WriteLine(shape.ToString() + "\n");

        //Circle
        Console.WriteLine(circle.ToString());
        Console.WriteLine(circle.getArea());
        Console.WriteLine(circle.getPerimeter());
        circle.Color = "yellow";
        circle.Fill = false;
        circle.Radius = 4;
        Console.WriteLine(circle.ToString());
        Console.WriteLine(circle.getArea());
        Console.WriteLine(circle.getPerimeter() + "\n");

        //Rectangle
        Console.WriteLine(rect.ToString());
        Console.WriteLine(rect.getArea());
        Console.WriteLine(rect.getPerimeter());
        rect.Color = "blue";
        rect.Fill = true;
        rect.Width = 55;
        rect.Length = 10;
        Console.WriteLine(rect.ToString());
        Console.WriteLine(rect.getArea());
        Console.WriteLine(rect.getPerimeter());

        Console.ReadLine();
    }
}
