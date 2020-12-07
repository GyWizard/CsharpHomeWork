using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeHelper;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("2.3");

            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");

            int a = 0;
            int sum = 0;


            while (true)
            {
                int.TryParse(Console.ReadLine(), out a);
                if(a==0)
                {
                    break;
                }
                if(a>0 && a%2!=0)
                {
                    sum += a;
                }
            }
            Console.WriteLine($"Cуммa всех нечетных положительных чисел = {sum}");
            HomeWork.Pause();
        }
    }
}
