using Project_Geometric_Shapes_Framework.Interfaces;
using System;

namespace Project_Geometric_Shapes_Framework.Classes;
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
        else if (_width == 0 || _length == 0)
        {
            string outText = (_width == 0 && _length == 0)
                ? "Width and Length cannot be zero"
                : _width == 0
                ? "Width cannot be zero"
                : "Length cannot be zero";
            Console.WriteLine(outText);
            return 0;
        }
        else
        {
            string outText = (_width < 0 && _length < 0)
                ? "Width and Length cannot be negative"
                : _width < 0
                ? "Width cannot be negative"
                : "Length cannot be negative";
            Console.WriteLine(outText);
            return -1;
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
        else if (_width == 0 || _length == 0)
        {
            string outText = (_width == 0 && _length == 0)
                ? "Width and Length cannot be zero"
                : _width == 0
                ? "Width cannot be zero"
                : "Length cannot be zero";
            Console.WriteLine(outText);
            return 0;
        }
        else
        {
            string outText = (_width < 0 && _length < 0)
                ? "Width and Length cannot be negative"
                : _width < 0
                ? "Width cannot be negative"
                : "Length cannot be negative";
            Console.WriteLine(outText);
            return -1;
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
