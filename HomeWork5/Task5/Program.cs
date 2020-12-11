using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using System.IO;
namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("5.5");

            Console.WriteLine(@"Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ,
правда это или нет. Например: «Шариковую ручку изобрели в древнем Египте», «Да». Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку.
Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ. 
Список вопросов ищите во вложении или воспользуйтесь интернетом.
-----------------------------------------------------------------------------------");

            StartGame("questions.txt");

            HomeWork.Pause();
        }

        public static void StartGame(string path)
        {
            Console.WriteLine("Добро пожаловать в детскую викторину! Если считаешь что утверждение верно напиши \"да\" если не верно \"нет\" ");
            int score = 0;
            Random r = new Random(); 
            int random = 0;
            List<string> questions = File.ReadAllLines(path).ToList(); //  Переводим все строки из файла в список строк
            Question quest; //  объявляем структуру
            for (int i = 0; i < 5; i++) //  Играем 5 раз
            {

                random = r.Next(0, questions.Count - 1); //  Получае рандомный индекс 
                quest = new Question(questions[random]); //  Заполняем структуру
                questions.RemoveAt(random); //  Удаляем вопрос из списка чтобы не повторялся
                Console.Write($"{quest.quest} : "); //  Задаем вопрос
                if (Console.ReadLine().ToLower().Equals(quest.answer)) //  Проверяем ответ , переводя его в нижний регистр
                {
                    Console.WriteLine("Правильно! +1 балл");
                    score++; //  добавляем балл если верно
                }
                else
                {
                    Console.WriteLine("Неправильно!");
                }
            }
            Console.WriteLine($"Вы набрали {score} баллов"); //  Выводим итоги

        }
    }
    public struct Question //  Структура в которой хранится вопрос и ответ
    {
        public string quest;
        public string answer;
        public Question(string line) //  Согласно правилу первая скобка будем началом ответа (
        {
            string[] l = line.Split('(');
            this.quest = l[0].Trim();
            this.answer = l[1].Replace(")","");
        }
    }
   

}
