using System;

namespace PensamientoComputacional
{
    class Program
    {

        static void Main(string[] args)
        {
            const double pi = Math.PI;

            Console.Write("Ingrese el valor del radio de un círculo: ");
            double r = double.Parse(Console.ReadLine());

            double a = pi * r * r;

            Console.WriteLine("El área del círculo es: {0}", a);
        }
    }
}
