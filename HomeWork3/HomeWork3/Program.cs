using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class HomeWork
    {
        static void Main(string[] args)
        {
            //PrintWelcomeMessage("0");
            //Pause(); 
        }

        public static void PrintWelcomeMessage(string number)
        {
            Console.WriteLine($"ФИО: Абдулаев Т.Ш.\nДомашнее задание GeekBrains номер {number}. \n");
        }
        public static void Pause()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Нажмите любую клавишу чтобы закрыть...");
            Console.ReadKey();
        }
    }
}
