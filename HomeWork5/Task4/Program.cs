using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using System.Text.RegularExpressions;
using System.IO;

namespace Task4
{
    partial class Program
    {
        static void Main(string[] args)
        {
            HomeWork.PrintWelcomeMessage("5.4");

            Console.WriteLine(@"*На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не
превосходит 100, каждая из следующих N строк имеет следующий формат:
<Фамилия> <Имя> <оценки>,
где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
Пример входной строки:
Иванов Петр 4 5 3
Требуется написать как можно более эффективную программу, которая будет выводить на экран
фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имен
------------------------------------------------------");

            FindWorstPupils("exam.txt");

            HomeWork.Pause();
        }

        public static int CheckString(string s)
        {

            if (Regex.IsMatch(s, @"^[А-Яа-я]{1,20} [А-Яа-я]{1,15} [2-5] [2-5] [2-5]$", RegexOptions.Multiline)) // Проверяем на корректность строку
            {
                Match match = Regex.Match(s, @"[2-5] [2-5] [2-5]"); // Находим оценки
                int score = (Convert.ToInt32(match.Value[0].ToString()) + Convert.ToInt32(match.Value[2].ToString()) + Convert.ToInt32(match.Value[4].ToString())); //  Подсчитываем сумму оценок
                return score;

            }
            Console.WriteLine($"Строка не соответствует заданному формату -  {s}"); // Возвращаем 0 и выводим строку ,сообщаем об ошибке в строке
            return 0;
        }

        public static void FindWorstPupils(string examPath)
        {
            string[] exam = File.ReadAllLines(examPath); // Загружаем список из файла
            PupilsWithScore list = new PupilsWithScore(); // Объявляем класс в котором хранятся 3 структуры описывающие список учеников и их оценку
            int count = Convert.ToInt32(exam[0]); // Первая строка должна соответствовать количеству учеников
            if (count<10) //  Минимум 10 учеников в списке
            {
                Console.WriteLine("Должно быть указано  минимум 10 учеников в первой строке");
                return;
            }
            int i = 0; // Тут будет хранится индекс группы 
            for (int y=1;y<count;y++) 
            {
                int s = CheckString(exam[y]); // Получаем оценку ученика
                if (s!=0)
                {
                    i = list.FindEqualOrMaxIndex(s); // Находим индекс группы, либо с такой же оценкой, если нет то с максимальной
                    if (s == list.pScores[i].score) // Если значения равны добавляем имя в список группы
                    {
                        list.pScores[i].names.Add(Regex.Match(exam[y], @"[А-Яа-я]{1,20} [А-Яа-я]{1,15}").Value);
                    }
                    if (s<list.pScores[i].score) // Если оценка меньше максимально хранящийся оценки, очищаем группу и добавляем фамилию и оценку
                    {
                        list.pScores[i].names.Clear();
                        list.pScores[i].names.Add(Regex.Match(exam[y], @"[А-Яа-я]{1,20} [А-Яа-я]{1,15}").Value);
                        list.pScores[i].score = s;
                    }
                                    
                }
            }
            list.PrintPupils(); // Отображаем учеников


        }

        }




}
