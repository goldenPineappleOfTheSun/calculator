using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    public class Calc
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        public double Div(double x, double y)
        {
            if (y != 0)
                return x / y;
            else
                // TODO
                return 0;
        }

        public double Max(double x, double y)
        {
            return Math.Max(x, y);
        }

        public double Min(double x, double y)
        {
            return Math.Min(x, y);
        }
    }
}
