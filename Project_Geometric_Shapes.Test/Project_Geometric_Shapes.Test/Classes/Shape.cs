
namespace Project_Geometric_Shapes.Test.Classes;
public abstract class Shape
{
    string _color;
    bool _fill;
    public string Color
    {
        get
        {
            return _color;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Color incorrect");
            }
            _color = value;
        }
    }
    public bool Fill { get { return _fill; } set { _fill = value; } }
    public Shape()
    {
        _color = "green";
        _fill = true;
    }
    public Shape(string Color, bool Fill)
    {
        _color = Color;
        _fill = Fill;
    }

    /// <summary>
    /// Return string: class Shape
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        try
        {
            string isFilled = _fill == true
                ? "filled"
                : "not filled";
            string text = $"A Shape with color of {_color} and {isFilled}";
            return text;
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
}
