using System;
using Helper;
namespace Task1
{
    public class RunTask
    {
        public void Task()
        {
            HomeWork.PrintWelcomeMessage("6.1");
            Console.WriteLine(@" Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). 
Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
-------------------------------------------");

            Console.WriteLine("a*x^2");

            Table(new Fun(MyFunc), 0, 3);
            Console.WriteLine("a*sin(x)");

            Table(new Fun(MyFuncSin), 0, 3);

            HomeWork.Pause();
        }

        public void Table(Fun F, double x, double b)
        {
            int a;
            do { Console.Write("Введите константу а: "); }
            while (Int32.TryParse(Console.ReadLine(), out a) != true);
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x)); // Считаем и выводим значения
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public double MyFunc(double a, double x) // Первая функция
        {
            return a * x * x;
        }
        public double MyFuncSin(double a, double x) // Вторая функция
        {
            return a * Math.Sin(x * Math.PI / 180);
        }
    }
}
