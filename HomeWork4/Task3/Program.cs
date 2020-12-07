using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("4.3");

            Console.WriteLine("Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password. \n");

            AccountDb accountDataBase = new AccountDb(); // Создаем экземпляр AccountDb который хранит данные об аккаунтах(Хранится в отдельном файле)
            accountDataBase.LoadDb("db.txt"); // Загружем БД

            if(accountDataBase.Authorize())
            {
                Console.WriteLine("Вы вошли в систему...");
            }

            HomeWork.Pause();
        }




    }
}
