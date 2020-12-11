using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
namespace Task2
{
    class Message
    {
        public static bool CheckForWord(string s)
        {
            foreach(char c in s)
            {
                if(!Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static void PrintLessThen(string message,int n ) // Находим слова меньше указанного количества символов
        {
            message=message.Replace("\r\n", "");
            string[] messageSplit= message.Split(' ',',','.');
                foreach (string s in messageSplit)
                {
                    if(CheckForWord(s)) // Проверям все ли символы буквы
                {
                        if (s.Length < n && s.Length>0)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    
                }
        }
        
        public static string DeleteAllWithEndOf(string message, char c) //  Удаляем все слова в конце которых есть указанный символ 
        {
            message = message.Replace("\r\n", "");
            string[] messageSplit = message.Split(' ', ',', '.');

            StringBuilder sb = new StringBuilder();
            foreach(string s in messageSplit)
            {
                if(!s.Equals(String.Empty))
                {
                    if(s[s.Length-1]!=c)
                    {
                        sb.Append($"{s} ");
                    }
                }
                
            }
            return sb.ToString();
        }

        public static string FindMax(string message) // Находим самое длинное слово 
        {
            message = message.Replace("\r\n", "");
            string max=String.Empty;
            string[] messageSplit = message.Split(' ', ',', '.');
            foreach (string s in messageSplit)
            {
                if(s.Length>max.Length)
                {
                    max = s;
                }
            }
            return max;
        }

        public static string MaxWords(string message) // Выводим все слова максимальной длины
        {
            message = message.Replace("\r\n", "");
            string[] messageSplit = message.Split(' ', ',', '.');
            int max = FindMax(message).Length;
            StringBuilder sb = new StringBuilder();
            foreach (string s in messageSplit)
            {
                if (s.Length==max)
                {
                    sb.Append($"{s} ");
                }
            }
            return sb.ToString();
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("5.2");

            Console.WriteLine(@"Разработать класс Message, содержащий следующие статические методы для обработки
текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
Продемонстрируйте работу программы на текстовом файле с вашей программой.
-----------------------------------------------------------------------------------");
            string text = File.ReadAllText("test.txt");
            Message.PrintLessThen(text, 5);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(Message.DeleteAllWithEndOf(text, 'e'));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(Message.FindMax(text));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(Message.MaxWords(text));
            HomeWork.Pause();
        }
    }
}
