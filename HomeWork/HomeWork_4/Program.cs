using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace HomeWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("4");

            Console.WriteLine("Задание :\nНаписать программу обмена значениями двух переменных.\nа) с использованием третьей переменной;\nб) *без использования третьей переменной.\n \n -=Меняем местами 1.0=- \n ");
            
            Console.Write("1. Введите первое число : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("2. Введите второе число : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"a={a}, b={b} ");

            Console.WriteLine("a)Меням с использованием третьей переменной");

            //C использованием третьей переменной
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"a={a}, b={b} ");



            //Без использования третьей переменной
            Console.WriteLine("b)Меняем еще раз БЕЗ использования третьей переменной ");
            a += b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a={a}, b={b} ");

            HomeWork.Pause();

        }
    }
}
