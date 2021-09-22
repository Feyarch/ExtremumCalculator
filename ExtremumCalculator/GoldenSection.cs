using System;
using System.Collections.Generic;
using System.Text;

namespace ExtremumCalculator
{
    class GoldenSection : ICalculator
    {
        private IFunction function;
        private const double PHI = 1.6180339887498948482;

        public GoldenSection(IFunction function)
        {
            this.function = function;
        }
        public double FindValue(double a, double b, double eps, ICalculator.Value value)
        {
            while (Math.Abs(b - a) > eps)
            {
                double x1 = GetB(b, b - a);
                double x2 = GetA(a, b - a);
                if (Check(function.GetY(x1), function.GetY(x2), value))
                {
                    a = x1;
                }
                else
                {
                    b = x2;
                }
            }
            return (a + b) / 2;

            bool Check(double a, double b, ICalculator.Value value)
            {
                switch (value)
                {
                    case ICalculator.Value.Max:
                        return a < b;
                    case ICalculator.Value.Min:
                        return a > b;
                    default:
                        throw new Exception("Error");
                }
            }
            double GetA(double a, double diff) => a + (diff) / PHI;
            double GetB(double a, double diff) => b - (diff) / PHI;

        }
    }
}
