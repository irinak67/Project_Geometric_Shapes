
namespace Project_Geometric_Shapes_Framework.Classes
{
    public abstract class Shape
    {
        string _color;
        bool _fill;

        public string Color { get { return _color; } set { _color = value; }}
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
        

        public override string ToString()
        {
            try
            {
                string isFilled = _fill == true ? "filled" : "not filled";
                string text = "A Shape with color of " + _color + " and " + isFilled;
                return text;
            }
            catch (System.Exception e)
            {
                return e.Message;
            }

        }
    }
}
