using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork4
{
    class MyMass
    {
        private int[] a;
        public MyMass(int n,int start,int step)
        {
            a = new int[n];
            a[0] = start;
            for(int i =1;i<n;i++)
            {
                a[i] = a[i - 1] + step;
            }
        }

        public int Sum
        {
            get
            {
                int s = 0;
                foreach(int t in a)
                {
                    s += t;
                }
                return s;
            }
        } //свойство сумма элементов

        public int MaxCount
        {
            get
            {
                return a.Length;
            }
        } // свойство максимальное количество элементов массива
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]<0)
                {
                    a[i] *= -1;
                }
            }
        } // инверсия
        public void Mult(int n)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= n;
            }
        } // умножение на число
        public void Save(string path)
        {
            File.WriteAllLines(path, Array.ConvertAll(a, IntToString));
        } // сохранение в файл
        public void Load(string path)
        {
           string[] temp = File.ReadAllLines(path);
            a = Array.ConvertAll(temp, StringToInt);
        } // загрузка из файла

        private string IntToString(int a)
        {
            
            return a.ToString();
        } // конвертер из числа в строку
        private int StringToInt(string s)
        {

            return int.Parse(s);
        } // конвертер из строки в число
        public void Print()
        {
            Console.Write(a[0]);
            for (int i =1;i< a.Length;i++)
            {
                Console.Write($",{a[i]}");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("4.2");

            Console.WriteLine("Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов. В Main продемонстрировать работу класса.\n");


            
            MyMass m = new MyMass(5, -15, 7);

            m.Print();
            
            Console.WriteLine($"Сумма элементов = {m.Sum}");

            m.Inverse();
            Console.WriteLine("Инвертируем...");
            m.Print();

            m.Mult(2);
            Console.WriteLine("Умножаем на 2...");
            m.Print();

            Console.WriteLine($"Максимальное количество элементов в массиве = {m.MaxCount}");

            Console.WriteLine("Записываем новый массив...");
            m.Save("mData.txt");

            m.Mult(4);
            Console.WriteLine("Умножаем на 4...");
            m.Print();
            Console.WriteLine("Загружем сохраненный массив из файла...");

            m.Load("mData.txt");
            m.Print();
            

            HomeWork.Pause();
        }
    }
}
