using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper.HomeWork.PrintWelcomeMessage("3.2");
            Console.WriteLine("а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.Напишите соответствующую функцию; ");
            Console.WriteLine();

            double value = 0;
            double sum = 0;
            Console.WriteLine("Вводите числа. Для выхода введите 0");
            do
            {
                Console.Write("Введите число : ");
                if (Double.TryParse(Console.ReadLine(), out value))
                {

                    if (value > 0 && value % 2 != 0)
                    {
                        sum += value;
                    }
                    else
                    {
                        if(value==0)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка Ошибка Ошибка. Необходимо ввести число ");
                }
            }
            while (true);
            Console.WriteLine($"Сумма положительных нечетных чисел : {sum}");


            Helper.HomeWork.Pause();
        }
    }
}
