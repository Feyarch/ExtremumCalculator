using System;

namespace ExtremumCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFunction func = new CustomFunction();

            Console.WriteLine("Min: " + new GoldenSection(func).FindValue(-10, 10, 0.00000001, ICalculator.Value.Min));
            Console.WriteLine("Max: " + new GoldenSection(func).FindValue(-10, 10, 0.00000001, ICalculator.Value.Max));
        }
    }
}
