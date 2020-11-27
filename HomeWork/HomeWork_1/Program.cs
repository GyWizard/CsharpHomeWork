using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace HomeWork_1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("1");

            Console.WriteLine("Задание :\nНаписать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку. \nа) используя склеивание\nб) используя форматированный вывод\nв) *используя вывод со знаком $.\n \n -=Анкета 1.0=-\n");


           
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите свою фамилию: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите свой возраст: ");
            string age  = Console.ReadLine();

            Console.Write("Введите свой рост (см): ");
            string height = Console.ReadLine();

            Console.Write("Введите свой вес (кг): ");
            string weight = Console.ReadLine();

            //a)
            Console.WriteLine($"a)Вас зовут "+lastName+" "+name+". Вам "+age+" лет. Ваш рост = "+height+" см, вес = "+weight+" кг");
            //b)
            Console.WriteLine(String.Format("б)Вас зовут {0} {1}. Вам {2} лет. Ваш рост = {3} см, вес = {4} кг",lastName,name,age,height,weight));
            //c)
            Console.WriteLine($"в)Вас зовут {lastName} {name}. Вам {age} лет. Ваш рост = {height} см, вес = {weight} кг");

            HomeWork.Pause();
        }
    }
}
