using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;



namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("5.3");

            Console.WriteLine(@" Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
а) с использованием методов C#;
б) *разработав собственный алгоритм.");

            Console.WriteLine("С помощью регулярных выражений");

            string s1 = Console.ReadLine();
            string s2= Console.ReadLine();


            IsAnagram(s1, s2); // С помощью сортировки
            IsAnagramMy(s1, s2); //  Собственный алгоритм

            HomeWork.Pause();
        }

        public static bool IsAnagram(string str1,string str2)
        {
            str1=str1.ToLower();  // Переводим строки в нижний регистр
            str2 =str2.ToLower();

            char[] s1 = str1.ToArray();
            char[] s2 = str2.ToArray();
            Array.Sort(s1);  // Сортируем строки по порядку
            Array.Sort(s2);
           
            if (s1.ToString().Equals(s2.ToString()))  //   Сравниваем отсортированые строки
            {
                Console.WriteLine("Строки являются анаграммами");
                return true;
            }
            Console.WriteLine("Строки НЕ являются анаграммами");
            return false;

        }

        public static bool IsAnagramMy(string str1, string str2)  // Сравниваем числовые суммы строк
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            
            if (CountString(str1)==CountString(str2))
            {
                Console.WriteLine("Строки являются анаграммами");
                return true;
            }
            Console.WriteLine("Строки НЕ являются анаграммами");
            return false;

        }

        public static int CountString(string str) // Считаем числовую сумму символов строки
        {
            int count = 0;
            foreach(char s in str)
            {
                count += (int)s;
            }
            return count;
        }

    }
}
