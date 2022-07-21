using System;

namespace Actividad3
{
    class Program
    {
        static bool bigger(double x, double y)
        {
            return x > y;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese un número a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Ingrese un número b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(bigger(a, b));
            Console.WriteLine(bigger(1, 3));
            Console.WriteLine(bigger(-10.8, -10.9));
        }
    }
}
