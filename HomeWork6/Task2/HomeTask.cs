using System;
using System.Collections.Generic;
using System.IO;
using Helper;
namespace Task2
{
    public delegate double Func(double x);
    public class HomeTask
    {
        public void RunTask()
        {
            HomeWork.PrintWelcomeMessage("6.2");
            Console.WriteLine(@"Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
возвращает минимум через параметр.
----------------------------------------
");


            double a;
            double b;
            double h;
            int f = 0;
            Console.WriteLine("Функции 1: F(x^2) | 2: F(sin(x)) | 3: F(cos(x))");
            do { Console.Write("Выберите функцию (1,2,3) : "); }
            while (Int32.TryParse(Console.ReadLine(), out f) != true); // Считываем номер функции

            do { Console.Write("Введите минимум : "); }
            while (Double.TryParse(Console.ReadLine(), out a) != true); //  Минимальное значение

            do { Console.Write("Введите максимум : "); }
            while (Double.TryParse(Console.ReadLine(), out b) != true); // Максимальное значение

            do { Console.Write("Введите шаг : "); }
            while (Double.TryParse(Console.ReadLine(), out h) != true); //  Шаг

            SaveFunc("text.txt", a, b, h, funcList[f-1]); // Сохраняем значения функции в файл

            double min;
            double[] res = Load("text.txt", out min); // Ищем минимальное значение из файла
            Console.WriteLine($"Минимальное значение = {min:F2}"); 

            HomeWork.Pause();
            
        }
        public HomeTask() // Конструктор
        {
            funcList = new List<Func>();
            funcList.Add(F);
            funcList.Add(FSin);
            funcList.Add(FCos);
        }
        public List<Func> funcList; 
        public double F(double x) // Во второй степени
        {
            return x * x;
        }
        public double FSin(double x) // Синус
        {
            return Math.Sin(x * Math.PI / 180);
        }
        public double FCos(double x) // Косинус
        {
            return Math.Cos(x * Math.PI / 180);
        }
        public void SaveFunc(string fileName, double a, double b, double h, Func F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double[] d = new double[0];
           
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                Array.Resize(ref d, d.Length + 1);
                d[i] = bw.ReadDouble();
                if (d[i] < min) min = d[i];
            }
            bw.Close();
            fs.Close();
            return d;
        }

    }
    }

    
