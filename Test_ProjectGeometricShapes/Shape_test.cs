using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Geometric_Shapes.Tests
{
    public class Shape_test
    {
        string? color;
        bool? fill;

        public Shape_test()
        {
            color = "green";
            fill = true;
        }
        public Shape_test(string? Color, bool? Fill)
        {
            color = Color;
            fill = (bool)Fill;
        }

        ////TODO
        //string GetColor()
        //{
        //    return color;
        //    //string isFilled = fill == true ? "filled" : "Not filled";
        //    //string text = "A Shape with color of " + color + " and " + isFilled;
        //    //return text;
        //}

        //void SetColor(string color)
        //{
        //    this.color = color;
        //}

        ////TODO
        //bool isFilled()
        //{
        //    return true;
        //}
        //void setFilled(bool fill)
        //{
        //    fill = fill;
        //}
        public override string ToString()
        {
            string isFilled = fill == true ? "filled" : "not filled";
            string text = "A Shape with color of " + color + " and " + isFilled;
            return text;
            //return base.ToString();
        }
    }
}
