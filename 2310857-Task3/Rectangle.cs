using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2310857_Task3
{
    internal class Rectangle
    {
        public double length;
        public double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public bool isSquare() // check if square
        {
            return length == width;
        }
        public double Area() // calculate area
        {
            return length * width;
        }

        public double Perimeter() //calculate perimeter
        {
            return (length + width) * 2;
        }
    }
}
