using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeHelper;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("2.1");

            Console.WriteLine("Написать метод, возвращающий минимальное из трех чисел.");

            Console.Write("Введите первое число : ");
            int a = 0;
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Введите второе число : ");
            int b = 0;
            int.TryParse(Console.ReadLine(), out b);
            Console.Write("Введите третье число : ");
            int c = 0;
            int.TryParse(Console.ReadLine(),out c);

            FindMax(a, b, c);

            HomeWork.Pause();


        }
        public static void FindMax(int a,int b,int c)
        {
            if(a>b&&a>c)
            {
                    Console.WriteLine($"Наибольшее число = {a}");              
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine($"Наибольшее число = {b}");
                }
                else
                {
                    Console.WriteLine($"Наибольшее число = {c}");
                }
            }


        }
    }
}
