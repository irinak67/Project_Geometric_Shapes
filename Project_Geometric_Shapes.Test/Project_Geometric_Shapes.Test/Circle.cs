﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Geometric_Shapes.Test
{
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
        public Circle(double radius, string Color, bool Fill) : base ( Color, Fill )
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
                double area = Math.Round(3.14 * _radius * _radius, 2);
                return area;
            }
            else
            {
                Console.WriteLine("incorrect radius value");
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
                double perimeter = Math.Round(2 * 3.14 * _radius, 2);
                return perimeter;
            }
            else
            {
                Console.WriteLine("incorrect radius value");
                return 0;
            }

        }

        public override string ToString()
        {
            string text = "A Circle with radius = " + _radius + ", which is a subclass of " + base.ToString();
            return text;
        }
    }
}
