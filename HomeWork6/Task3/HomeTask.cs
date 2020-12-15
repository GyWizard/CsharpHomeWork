using System;
using Helper;
using System.Collections.Generic;
using System.IO;

namespace Task3
{
 

    class HomeTask
    {

        int SortByName(Student st1, Student st2)         // Создаем метод для сравнения для экземпляров
        {

            return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
        }
        int SortByAge(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {

            return st1.age.CompareTo(st2.age);          // Сравниваем две строки
        }
        int SortByCourseAndAge(Student st1, Student st2) // Создаем метод для сравнения для экземпляров
        {
            if(st1.course>st2.course)
            {
                return 1;
            }
            else
            {
                if (st1.course == st2.course)
                {
                    if (st1.age == st2.age)
                    {
                        return 0;
                    }
                    if (st1.age>st2.age)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }
                   
            }
        }
        Dictionary<int, int> CountCours(List<Student> l,int min,int max) // Студенты от 18 до 20 сколько на каких курсах
        {
            Dictionary<int, int> stud = new Dictionary<int, int>();
            foreach (Student s in l)
            {
                if(s.age>=min&&s.age<=max)
                {
                    if (stud.ContainsKey(s.course)) // Проверяем есть ли ключ 
                    {
                        stud[s.course]++;
                    }
                    else
                    {
                        stud.Add(s.course, 1);
                    }
                }
            }
            return stud;
        }

        public delegate bool CompareDel(Student s); // Делегат для сравнения

        public int Count(List<Student> list, CompareDel Com) // Метод считающий количество студентов с условием
        {
            int c = 0;
            foreach(Student s in list)
            {
                if(Com(s))
                {
                    c++;
                }
            }
            return c;
        }

        public bool IsCapital(Student s) //  Предикат для поиска студентов из столицы
        {
            return s.city.Equals("Москва");
        }
        public bool IsAdult(Student s) //  Предикат для поиск студентов старше 18
        {
            return s.age>=18;
        }

        public List<Student> LoadStudents(out int b, out int m)
        {
            b = 0;
            m = 0;
            List<Student> list = new List<Student>();                             // Создаем список студентов
            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[5]) < 5) b++; else m++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) break;
                }
            }
            sr.Close();
            return list;
        }
        public void Run()
        {
            HomeWork.PrintWelcomeMessage("6.3");
            Console.WriteLine(@"Переделать программу «Пример использования коллекций» для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
            в) отсортировать список по возрасту студента;
            г) *отсортировать список по курсу и возрасту студента;
            д) разработать единый метод подсчета количества студентов по различным параметрам
            выбора с помощью делегата и методов предикатов.
--------------------------------------------------
                                                    ");

            int bakalavr = 0;
            int magistr = 0;

            List<Student> list = LoadStudents(out bakalavr, out magistr);



            Console.WriteLine("------Сортировка по имени\n");
            
            list.Sort(new Comparison<Student>(SortByName));
            foreach (var v in list) Console.WriteLine($"Имя - {v.firstName}, возраст - {v.age}, курс - {v.course}");

            Console.WriteLine("\n------Сортировка по возрасту\n");
            list.Sort(new Comparison<Student>(SortByAge));
            foreach (var v in list) Console.WriteLine($"Имя - {v.firstName}, возраст - {v.age}, курс - {v.course}");

            Console.WriteLine("\n------Сортировка по курсу и возрасту\n");
            list.Sort(new Comparison<Student>(SortByCourseAndAge));
            foreach (var v in list) Console.WriteLine($"Имя - {v.firstName}, возраст - {v.age}, курс - {v.course}");

            Console.WriteLine("------");

            foreach (KeyValuePair<int, int> val in CountCours(list,18,20))
            {
                Console.WriteLine($"Курс {val.Key} количество студентов от 18 до 20 - {val.Value}");
            }
     
            Console.WriteLine("Всего студентов:{0}",list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);


            Console.WriteLine("Совершеннолетних:{0}", Count(list, IsAdult)); // Считаем студентов старше 18
            Console.WriteLine("Из Москвы:{0}", Count(list, IsCapital)); // Считаем студентов из Москвы

            HomeWork.Pause();
        }
    }

}
