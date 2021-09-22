using System;
using System.Collections.Generic;
using System.Text;

namespace ExtremumCalculator
{
    interface ICalculator
    {
        enum Value
        {
            Max, Min
        }
        public double FindValue(double a, double b, double eps, Value value);
            
    }
   
}
