using System;

namespace ExtremumCalculator
{
    class CustomFunction : IFunction
    {
        //default function
        private double Func(double x) => (x + Math.Sin(x) + 1) * (x - Math.Cos(x) + 2);

        private readonly Func<double, double> func;
        public CustomFunction()
        {
            func = Func;
        }
        public CustomFunction(Func<double, double> func)
        {
            this.func = func;
        }
        public double GetY(double x)
        {
            return func(x);
        }
        
    }
}
