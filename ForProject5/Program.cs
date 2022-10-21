using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForProject5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = 15;
            double a = 30;
            double f;
            for (double i = c; i <= a; i++)
            {
                f = 1.8 * i + 32;
                Console.WriteLine("f= " + f);

            }
            Console.ReadKey();

        }
    }
}
