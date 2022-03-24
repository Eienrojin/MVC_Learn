using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Learn
{
    internal class Model
    {
        public double CalcSqrtRoot(double a, double b)
        {
            double result = Math.Sqrt(a * a + b * b);

            return result;
        }
    }
}
