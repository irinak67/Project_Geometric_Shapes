using Project_Geometric_Shapes.Test.Interfaces;

namespace Project_Geometric_Shapes.Test.Classes;
public class Rectangle : Shape, IGeometricObject
{
    public double _width;
    public double _length;
    public double Width
    {
        get { return _width; }
        set { _width = value; }
    }
    public double Length
    {
        get { return _length; }
        set { _length = value; }
    }
    public Rectangle()
    {
        _width = 1.0;
        _length = 1.0;
    }
    public Rectangle(double width, double length)
    {
        _width = width;
        _length = length;
    }
    public Rectangle(double width, double length, string Color, bool Fill) : base(Color, Fill)
    {
    }

    /// <summary>
    /// Get a area of the rectangle
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public double getArea()
    {
        if (_width > 0 && _length > 0)
        {
            double area = Math.Round(_width * _length, 2);
            return area;
        }
        else
        {
            string outText = (_width <= 0 && _length <= 0) 
                ? "incorrect Width and Length value"
                : _width <= 0 
                ? "incorrect Width value" 
                : "incorrect Length value";
            Console.WriteLine(outText);
            return 0;
        }
    }

    /// <summary>
    /// Get a perimeter of the rectangle
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public double getPerimeter()
    {
        if (_width > 0 && _length > 0)
        {
            double perimeter = Math.Round(2 * (_width + _length), 2);
            return perimeter;
        }
        else
        {
            string outText = (_width <= 0 && _length <= 0) 
                ? "incorrect Width and Length value" 
                : _width <= 0 
                ? "incorrect Width value" 
                : "incorrect Length value";
            Console.WriteLine(outText);
            return 0;
        }
    }

    /// <summary>
    /// Return string: class Rectangle
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        string text = $"A Rectangle with width = {_width} and length = {_length}, which is a subclass of {base.ToString()}";
        return text;
    }
}
