using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2310857_Task3
{
    internal class Triangle
    {
        public double side1;
        public double side2;
        public double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public string triangleType()
        {
            double[] values = new double[3] { this.side1, this.side2, this.side3 };
            if (this.side1 <= 0 || this.side2 <= 0 || this.side3 <= 0)
            {
                return "nothing";
            }
            else if (values.Distinct().Count() == 1) //There is only one distinct value in the set, therefore all sides are of equal length
            {
                return "Equilateral";
            }
            else if (values.Distinct().Count() == 2) //There are only two distinct values in the set, therefore two sides are equal and one is not
            {
                return "Isosceles";
            }
            else if (values.Distinct().Count() == 3) // There are three distinct values in the set, therefore no sides are equal
            {
                return "Scalene";
            }
            return "idk";


        }
    }
}
