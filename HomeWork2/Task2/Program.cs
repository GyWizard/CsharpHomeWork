using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeHelper;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            HomeWork.PrintWelcomeMessage("2.2");

            Console.WriteLine("Написать метод подсчета количества цифр числа.");


            Console.Write("Введите число : ");
            int a = 0;
            int.TryParse(Console.ReadLine(), out a);

            Console.WriteLine($"Количество цифр в числе : {CountNumbers(a)}");



            HomeWork.Pause();
            
        }

        public static int CountNumbers(int a)
        {
            int n = 0;
            while(a>=1)
            {
                a /= 10;
                n++;
            }
            return n;
        }
    }
}
