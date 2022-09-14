using Project_Geometric_Shapes.Test.Interfaces;

namespace Project_Geometric_Shapes.Test.Classes;
public class Circle : Shape, IGeometricObject
{
    private double _radius;
    public double Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }
    public Circle()
    {
        _radius = 1.0;
    }
    public Circle(double radius)
    {
        _radius = radius;
    }
    public Circle(double radius, string Color, bool Fill) : base(Color, Fill)
    {
    }

    /// <summary>
    /// Get a area of the circle
    /// </summary>
    /// <returns></returns>
    public double getArea()
    {
        if (_radius > 0)
        {
            double area = 3.14 * _radius * _radius;
            return Math.Round(area, 2);
        }
        else
        {
            if (_radius < 0)
            {
                Console.WriteLine("Radius cannot be negative");
                return -1;
            }
            Console.WriteLine("Radius cannot be zero");
            return 0;
        }
    }

    /// <summary>
    /// Get a perimeter of the circle
    /// </summary>
    /// <returns></returns>
    public double getPerimeter()
    {
        if (_radius > 0)
        {
            double perimeter = 2 * 3.14 * _radius;
            return Math.Round(perimeter, 2);
        }
        else
        {
            if (_radius < 0)
            {
                Console.WriteLine("Radius cannot be negative");
                return -1;
            }
            Console.WriteLine("Radius cannot be zero");
            return 0;
        }
    }

    /// <summary>
    /// Return string: class Circle
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        string text = $"A Circle with radius = {_radius}, which is a subclass of {base.ToString()}";
        return text;
    }
}
