using Project_Geometric_Shapes_Framework.Classes;
using System;

namespace Project_Geometric_Shapes_Framework;
class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        Rectangle rect = new Rectangle();

        Console.WriteLine(circle.ToString());
        circle.getArea();
        circle.getPerimeter();

        rect.ToString();
        rect.getArea();
        rect.getPerimeter();
        Console.ReadLine();
    }
}
