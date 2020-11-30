using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeHelper;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("2.7");

            Console.WriteLine("a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.");

            Console.Write("Введите первое число : ");
            int a = 0;
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Введите второе число : ");
            int b = 0;
            int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine($"Сумма чисел = {PrintNumbersBetween(a, b)}");

            HomeWork.Pause();
        }

        public static int PrintNumbersBetween(int x, int y)
        {
            if(x<=y)
            {
                Console.WriteLine(x);
                return x+PrintNumbersBetween(x + 1, y);
            }
            return 0;
        }

    }
}
