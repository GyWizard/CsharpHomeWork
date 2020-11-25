using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("2");

            Console.WriteLine("Задание :\nВвести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.\n \n -=ИМТ 1.0=- \n ");

            Console.Write("Введите рост (см) : ");
            double height = Convert.ToDouble(Console.ReadLine());
            height /= 100;

            Console.Write("Введите вес (кг) : ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("================");
            Console.WriteLine($"ИМТ : {(weight/(height*height)).ToString("F1")}\n");

            HomeWork.Pause();
        }
    }
}
