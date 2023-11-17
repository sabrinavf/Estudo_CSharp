using System;
using System.Globalization;

namespace Estudo
{
    class Progam
    {
        static void Main(string[] args)
        {
            double n = 3.14159;
            double raio, area, N, A;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * (Math.Pow(raio,2));

            Console.WriteLine("A=" + area.ToString("F4"),CultureInfo.InvariantCulture);




        } 
    }
}