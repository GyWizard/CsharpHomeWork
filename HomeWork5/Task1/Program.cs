using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using System.Text.RegularExpressions;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("5.1");

            Console.WriteLine(@" Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 
2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) с использованием регулярных выражений.");
            Console.Write("Без регулярных выражений:");
            CheckPassword(Console.ReadLine());
            Console.Write("С помощью регулярных выражений:");
            CheckPasswordRegex(Console.ReadLine());

            HomeWork.Pause();
        }

        public static bool CheckPassword(string password)
        {
           
            if (password.Length>10||password.Length<2) // Проверка на длину
            {
                Console.WriteLine("Пароль должен быть от 2 до 10 символов");
                Console.Write("Повторите попытку :");
                return CheckPassword(Console.ReadLine());
            }
            if(Char.IsNumber(password[0])) // Первый символ не должен быть цифрой
            {
                Console.WriteLine("Первый символ не должен быть цифрой");
                Console.Write("Повторите попытку :");
                return CheckPassword(Console.ReadLine());
            }

            int dec;

            foreach (char c in password)
            {
                if(!Char.IsLetterOrDigit(c))
                {
                    Console.WriteLine("Пароль должен состоять только из цифр и букв латинского алфавита"); // Проверяем является ли символ числом или буквой
                    return CheckPassword(Console.ReadLine());
                }
                if(Char.IsLetter(c)) //  Если является буквой проверяем является ли латинской
                {
                    dec = (int)c;
                    if ( !( (dec>=65&&dec<=90) || (dec >= 97 && dec <= 122) ) )  // 65=A 90=Z 97=a 122=z
                    {
                        Console.WriteLine("Пароль должен состоять только из букв латинского алфавита");
                        Console.Write("Повторите попытку :");
                        return CheckPassword(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine("Пароль подходит!!!");
            return true;
        }

        public static bool CheckPasswordRegex(string password) //С помощью выражения
        {
            Console.Write("Повторите попытку :");
            if (Regex.IsMatch(password, @"^([A-za-z][0-9A-Za-z]{1,9})$", RegexOptions.Multiline))
            {
                Console.WriteLine("Пароль подходит!!!");
                return true;
            }
            return CheckPasswordRegex(Console.ReadLine());
        }
    }
}
