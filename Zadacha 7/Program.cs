using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите меньшее число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите большее число:");
            int b = int.Parse(Console.ReadLine());
            int k = 0;
            int s = 0;
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i + " ");
                k++;
                s = s + i;
            }
            Console.WriteLine("Количество чисел между меньшим и большим числом:" + " " + k);
            Console.WriteLine("Сумма чисел между меньшим и большим числом:" + " " + s);
            Console.ReadLine();
        }
    }
}
