using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForProject7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double c;
            double sum;
            sum = 0;
            for (double i = 1; i <= 7; i++)
            {
                c = i % 10;
                sum += c;
            }
            Console.WriteLine("Cумма элементов массива " + sum);
            Console.ReadKey();

        }
    }
}
