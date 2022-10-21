using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForProject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a = 1;
            Console.WriteLine("Введите значение n ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= n; i++)
            {
                sum = 1 + i;
                Console.WriteLine(" " + sum);

            }
            Console.ReadKey();

        }
    }
}
