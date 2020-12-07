using System;
using System.IO;

namespace HomeWork4
{
    struct AccountDb
    {
        public struct Account
        {
            string login;
            string password;
            public Account(string login, string password)
            {
                this.login = login;
                this.password = password;
            }

            public bool Check(string login, string password)
            {
                if (this.login.Equals(login)&&this.password.Equals(password) )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        Account[] db;

        public  void LoadDb(string path) // Загрузка БД из файла
        {
            Console.WriteLine("Загрузка БД");
            string[] temp = File.ReadAllLines(path);
            if (temp.Length>1 && temp.Length%2==0) // Проверяем есть ли минимум 2 записи. И количество строк . Первая строка логин, вторая пароль. 
            {
                db = new Account[temp.Length / 2]; // Определяем размер массива
                for (int i = 0; i < db.Length; i++)
                {
                    db[i] = new Account(temp[i*2], temp[i*2+1]);  //  Добавляем аккаунт в массив   
                }
                Console.WriteLine("БД загружена...");
                
            }
            else
            {
                Console.WriteLine("Файл пустой или неверного формата");
            }
        }

        public bool Authorize()
        {
            Console.Write("Введите логин :");
            string login = Console.ReadLine();
            Console.Write("Введите пароль :");
            string password = Console.ReadLine();
            foreach(Account a in db) // обходим все аккаунты и сверяем данные
            {
                if(a.Check(login,password))
                {
                    return true;
                }
            }
            Console.WriteLine("Неверный логин или пароль. Повторите попытку");
            Console.WriteLine("--------------------------------------------");
            return Authorize(); // Если ничего не нашлось повторяем попытку авторизации
        }

    }
}
