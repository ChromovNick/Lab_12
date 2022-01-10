using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    static class Circle
    {
        static public double GetCircumference (double r)
        {
            return r * 2 * Math.PI;
        }
        static public double  GetSquare (double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }
        static public bool GetCoordinates (double x, double y, double r)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) < r;
        }

    }

}
