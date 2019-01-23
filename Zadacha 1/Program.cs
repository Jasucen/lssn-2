using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    class Program
    {
        static int MinNum()
        {
            Console.WriteLine("Введите целое число:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье целое число:");
            int c = Convert.ToInt32(Console.ReadLine());

            int min = a;

            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Наименьшее из трех введенных чисел равно " + MinNum());
            Console.ReadLine();
        }
    }
}
