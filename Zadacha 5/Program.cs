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



             

            Console.WriteLine("Ваш рост:");
            String height = Console.ReadLine();
            double h = Convert.ToDouble(height) / 100;

            Console.WriteLine("Ваш вес:");
            String weight = Console.ReadLine();
            double w = Convert.ToDouble(weight);

            double bmi = w / (h * h);

            if (bmi >= 16 && bmi <= 18.4)
            {
                Console.WriteLine("Индекс Вашей массы тела" + " " + bmi);
                Console.WriteLine("Срочно наберите вес!");
                Console.ReadLine();
            } else if (bmi >= 18.5 && bmi <=24.99 ) 
               {
                Console.WriteLine("Индекс Вашей массы тела" + " " + bmi);
                Console.WriteLine("Ваш вес в норме, так держать.");
                Console.ReadLine();
            } else if(bmi >= 25 && bmi <= 30)
            {
                Console.WriteLine("Индекс Вашей массы тела" + " " + bmi);
                Console.WriteLine("У вас легкое ожирение, сбросьте несколько килограмм.");
                Console.ReadLine();
            } else if (bmi >= 30)
            {
                Console.WriteLine("Индекс Вашей массы тела" + " " + bmi);
                Console.WriteLine("Я не могу понять, ты планета с собственной орбитой или уже нейтронная звезда и проваливаешься внутрь себя?");
                Console.ReadLine();
            }

          


            Console.ReadLine();



            
            

            }


        }
    }

