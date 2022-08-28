using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Geometric_Shapes.Test
{
    public abstract class Shape 
    {
        string _color;
        bool _fill;

        public Shape()
        {
            _color = "green";
            _fill = true;
        }
        public Shape(string Color, bool Fill)
        {
            _color = Color;
            _fill = (bool)Fill;
        }

        public override string ToString()
        {
            string isFilled = _fill == true ? "filled" : "not filled";
            string text = "A Shape with color of " + _color + " and " + isFilled;
            return text;
            //return base.ToString();
        }
    }
}
