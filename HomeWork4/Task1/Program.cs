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
            HomeWork.PrintWelcomeMessage("4.1");

            Console.WriteLine("Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.\n");

            int[] m = new int[20]; 

            InputMass(m);  //Заполняем массив вводя элементы

            Console.WriteLine($"Количество пар делящихся  на 3 = {CountPairs(m)}"); 
            

            HomeWork.Pause();
        }

        public static void InputMass(int[] massive )
        {
            int i = 0;
            while(i<massive.Length)
            {
                Console.Write($"m{i+1} : ");
                if (int.TryParse(Console.ReadLine(), out massive[i]) && massive[i]>=-10000 && massive[i]<=10000) // Проверяем на число и на нужный диапозон
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Необходимо ввести число от -10 000 до 10 000");
                }
            }
        }

        public static int CountPairs(int[] massive)
        {
            int p = 0;
            for(int i = 0; i<massive.Length-1;i++)
            {
                if(massive[i]%3==0 || massive[i+1] % 3 == 0) //Если элемент кратен 3 или следующий элемент кратен 3 добавляем пару
                {
                    p++;
                }
            }
            return p;
        }

    }

}
