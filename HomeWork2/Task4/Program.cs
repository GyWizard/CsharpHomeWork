using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeHelper;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("2.4");

            Console.WriteLine("Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.");

            int attempts = 3;

            do
            {
                Console.Write("Login : ");
                string login = Console.ReadLine();
                Console.Write("Password : ");
                string password = Console.ReadLine();
                if (Authorize(login, password))
                {
                    Console.WriteLine("УСПЕШНО! Входим в систему...");
                    break;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Введен неверный логин или пароль. Осталось попыток {attempts}");
                }
                
            }
            while (attempts != 0);

            HomeWork.Pause();
        }
        public static bool Authorize(string login,string password)
        {
            if(login.Equals("root")&&password.Equals("GeekBrains"))
            {
                return true;
            }
            return false;
        }
    }
}
