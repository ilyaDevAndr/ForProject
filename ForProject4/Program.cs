using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForProject4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число = ");
            int g = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int a = 1;
            int n = 10;
            for (int i = a; i <= n; i++)
            {
                c = g * i;
                Console.WriteLine(" " + g + "*" + "" + i + "=" + c);

            }
            Console.ReadKey();

        }
    }
}
