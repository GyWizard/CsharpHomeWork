using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeHelper;

namespace Task5
{
    class Program
    {
     
        static void Main(string[] args)
        {

            HomeWork.PrintWelcomeMessage("2.5");

            Console.WriteLine("а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");

            double normal_min = 18.5;
            double normal_max = 25;


            Console.Write("Введите рост (см): ");
            double height = 0;
            double.TryParse(Console.ReadLine(), out height);
            height /= 100;
            Console.Write("Введите вес (кг): ");
            double weight = 0;
            double.TryParse(Console.ReadLine(), out weight);

            double massIndex = weight / (height * height);

            Console.WriteLine($"Индекс массы тела = {massIndex:F2}");

            if(massIndex>= normal_min && massIndex<= normal_max)
            {
                Console.WriteLine("Вес находится в норме");
            }
            else
            {
                if (massIndex < normal_min)
                {
                    Console.WriteLine("Недостаточный вес");
                    Console.WriteLine($"Нужно набрать {(normal_min * height*height)-weight:F2} кг для нормализации веса");
                }
                else
                {
                    Console.WriteLine("Избыточный вес");
                    Console.WriteLine($"Нужно похудеть на  {weight-(normal_max * height * height):F2} кг для нормализации веса");
                }
            }


            HomeWork.Pause();

        }
    }
}
