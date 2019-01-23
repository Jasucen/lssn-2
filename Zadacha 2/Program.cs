using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число для подсчета количества цифр в нем:");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            while (n != 0)
            {
                count++;
                n = n / 10;
            }
            Console.WriteLine("Количество цифр в числе " + n + " - " + count);
            Console.ReadLine();
        }
    }
}

    



