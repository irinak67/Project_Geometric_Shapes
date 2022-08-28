using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Geometric_Shapes.Test
{
    internal class Circle : Shape, IGeometricObject
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle()
        {
            double _radius = 1.0; 
        }
        public Circle(double radius)
        {
            _radius = radius;
        }
        public Circle(double radius, string Color, bool Fill) : base ( Color, Fill )
        {           
        }
        
        /// <summary>
        /// Get a area of the circle
        /// </summary>
        /// <returns></returns>
        public double getArea()
        {
            double area = 3.14 * _radius * _radius;
            return area;
        }

        /// <summary>
        /// Get a perimeter of the circle
        /// </summary>
        /// <returns></returns>
        public double getPerimeter()
        {
            double perimeter = 2 * 3.14 * _radius;
            return perimeter;
        }

        public override string ToString()
        {
            string text = "A Circle with radius = " + _radius + ", which is a subclass of " + base.ToString();
            return text;
        }
    }
}
