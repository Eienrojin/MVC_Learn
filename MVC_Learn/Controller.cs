using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Learn
{
    internal class Controller
    {
        public double GetSqrt(double a, double b)
        {
            Model model = new();

            double result = model.CalcSqrtRoot(a, b);

            return result;
        }
    }
}
