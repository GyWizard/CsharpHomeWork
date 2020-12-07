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
            HomeWork.PrintWelcomeMessage("4.4");

            Console.WriteLine(@"Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами.
            Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный
            элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, 
            используя модификатор ref или out)
            * б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
            Дополнительные задачи
            в) Обработать возможные исключительные ситуации при работе с файлами.");

            Console.WriteLine();
            Console.WriteLine("=====================================================");
            
            DoubleArray da = new DoubleArray(3,6);
            da.Print();
            Console.WriteLine($"Сумма всех элементов = {da.Sum()}");
            Console.WriteLine($"Сумма всех элементов больше 0 = {da.SumOver(0)}");
            Console.WriteLine($"Минимальный элемент = {da.Min}");
            Console.WriteLine($"Максимальный элемент = {da.Max}");
            int w;
            int h;
            da.MaxIndex(out w,out h);
            Console.WriteLine($"Номер максимального элемента {w},{h}");
            Console.WriteLine("Сохраняем матрицу в файл...");
            da.Save("matrixRandom.txt"); //Сохраняем матрицу


            Console.WriteLine("=====================================================");

            Console.WriteLine("Создаем матрицу из файла...");
            da = new DoubleArray("matrix.txt");//Вызываем ошибку такого файла нет
            da.Print();

            Console.WriteLine("=====================================================");

            Console.WriteLine("Создаем матрицу из файла..."); 
            da = new DoubleArray("matrix333.txt");//Вызываем ошибку такого файла нет
            da.Print();
            da = new DoubleArray("test");//Вызываем ошибку указан каталог
            da.Print();

            Console.WriteLine("=====================================================");
            Console.WriteLine("Загружаем матрицу из файла..."); 
            da.Load("matrixRandom.txt");
            da.Print();



            HomeWork.Pause();
        }
    }
}
