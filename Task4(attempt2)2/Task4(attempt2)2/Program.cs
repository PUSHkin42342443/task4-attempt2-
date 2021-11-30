using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_attempt2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = 2;
            double second = 3;

            double firstSumma = Koren(first, second);

            double third = 7;
            double forth = 8;

            double secondSumma = Koren(third, forth);

            double fifth = 1;
            double sixs = 4;

            double thirdSumma = Koren(fifth, sixs);

            double result = firstSumma + secondSumma + thirdSumma;

            Console.WriteLine($"конечный результат равен: {result:F3}");
            Console.ReadKey();
        }
      
        static double Koren(double l, double j)
        {
            return Math.Sqrt(l + Math.Tan(j)) / l * l + j * j;
        }

      
       
    }
}
