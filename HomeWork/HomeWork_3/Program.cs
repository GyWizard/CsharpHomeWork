using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("3");

            Console.WriteLine("Задание :\na)Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой)\nб) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;\n \n -=Считаем расстояние 1.0=- \n ");

            Console.WriteLine("1. Введите координаты первой точки");
            Console.Write("x : ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y : ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("2. Введите координаты второй точки");
            Console.Write("x : ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y : ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            
            //a)
            Console.WriteLine($"a)Расстояние между точками : {(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))).ToString("F2")}");
            //b)
            Console.WriteLine($"b)Расстояние между точками : { Distance(x1,y1,x2,y2).ToString("F2")}");

            HomeWork.Pause();

            
        }
        public static double Distance(double x1,double y1,double x2,double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
