using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForProject6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, f, sum;
            sum = 0;
            Console.WriteLine("Введем значение b с клавиатуры");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введем значение a с клавиатуры");
            a = Convert.ToDouble(Console.ReadLine());
            for (double i = a; i <= b; i++)
            {
                f = Math.Pow(i, 2);
                sum += f;
                Console.WriteLine("Квадрат от А до В= " + f);


            }
            Console.WriteLine("Сумма равна= " + sum);
            Console.ReadKey();

        }
    }
}
