using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("5");

            Console.WriteLine("Задание :\nНаписать программу, которая выводит на экран ваше имя, фамилию и город проживания.\nб) Сделать задание, только вывод организуйте в центре экрана\nв) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)\n \n -=Меняем местами 1.0=- \n ");

            string msg = "Тимур, Абдулаев, Москва.";
            //a)
            Console.WriteLine($"a){msg}");

            //b)
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"б){msg}");

            //c)
            Console.Write("Введите отступ по горизонтали : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите отступ по вертикали : ");
            int y = Convert.ToInt32(Console.ReadLine());

            WriteAtPosition(msg, x, y);

            HomeWork.Pause();
        }

        public static void WriteAtPosition(string ms,int x,int y)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine($"в){ms}");
        }
    }
}
