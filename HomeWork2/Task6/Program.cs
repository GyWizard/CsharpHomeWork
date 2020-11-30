using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeHelper;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            HomeWork.PrintWelcomeMessage("2.6");

            Console.WriteLine("Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.");

            DateTime startTime = DateTime.Now;

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Считаем количество «Хороших» чисел в диапазоне от 1 до 1 000 000 000");
            int count = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                if(i % Sum(i) == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество хороших чисел в заданном диапазоне : {count} ");

            Console.WriteLine($"Время выполнения программы : {startTime-DateTime.Now} ");
            HomeWork.Pause();
        }

        public static int  Sum(int a)
        {
            int divider = 0;
            while (a >= 1)
            {
                divider += a % 10;
                a /= 10;
            }
            return divider;
        }
    }
}
