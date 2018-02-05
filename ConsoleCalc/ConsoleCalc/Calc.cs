using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    public class Calc
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

        public int Div(int x, int y)
        {
            if (y != 0)
                return x / y;
            else
                // TODO
                return 0;
        }

        public int Max(int x, int y)
        {
            return Math.Max(x, y);
        }

        public int Min(int x, int y)
        {
            return Math.Min(x, y);
        }
    }
}
