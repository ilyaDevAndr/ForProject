using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            double A = 10, B = 20;
            for (double i = A; i <= B; i++)
            {
                Console.WriteLine(" " + i + " В квадрате " + Math.Pow(i, 2));
            }
            Console.ReadLine();

        }
    }
}
