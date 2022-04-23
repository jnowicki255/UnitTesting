using System;

namespace UnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 4.6;

            Console.WriteLine(Math.Round(Arithmetics.Add(a, b), 2));
            Console.WriteLine(Math.Round(Arithmetics.Substract(a, b), 2));
            Console.WriteLine(Math.Round(Arithmetics.Multiply(a, b), 2));
            Console.WriteLine(Math.Round(Arithmetics.Divide(a, b), 2));
        }
    }
}
