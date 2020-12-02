using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Fraction
    {
        int nu;
        int de;

        public Fraction(int nu, int de)
        {
            this.nu = nu;
            this.de = de;
            if (de==0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
            
        }

        public string Print()
        {
            return ($"{nu}/{de}");
        }
        public static Fraction Sum(Fraction a, Fraction b)
        {

            int n = a.nu;
            int n2 = b.nu;
            int d = a.de;
            if (a.de != b.de)
            {
                n *= b.de;
                n2 *= a.de;
                d *= b.de;
            }

            return new Fraction(n + n2, d);
        }
        public static Fraction Substract(Fraction a, Fraction b)
        {
            int n = a.nu;
            int n2 = b.nu;
            int d = a.de;
            if (a.de != b.de)
            {
                n *= b.de;
                n2 *= a.de;
                d *= b.de;
            }

            return new Fraction(n - n2, d);
        }
        public static Fraction Mult(Fraction a, Fraction b)
        {
            return new Fraction(a.nu * b.nu,a.de * b.de);
        }
        public static Fraction Div(Fraction a, Fraction b)
        {
            return new Fraction(a.nu * b.de, a.de * b.nu);
        }
        public void ToSimple()
        {

            int min;
            if(nu<=de)
            {
                min = nu;
            }
            else
            {
                min = de;
            }

            for (int i = min;i>1;i--)
            {
                if(nu%i==0 && de%i==0)
                {
                    nu /= i;
                    de /= i;
                    break;
                }
            }


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Helper.HomeWork.PrintWelcomeMessage("3.3");
            Console.WriteLine("Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса. * *Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключениеArgumentException(Знаменатель не может быть равен 0); ");
            Console.WriteLine("==================================");

            
            int n = 0;
            int d = 0;

            Console.Write("Введите числитель первого числа : ");
            Int32.TryParse(Console.ReadLine(), out n);
            Console.Write("Введите знаменатель первого числа : ");
            Int32.TryParse(Console.ReadLine(), out d);

            Fraction a = new Fraction(n, d);

            Console.Write("Введите числитель второго числа : ");
            Int32.TryParse(Console.ReadLine(), out n);
            Console.Write("Введите знаменатель второго числа : ");
            Int32.TryParse(Console.ReadLine(), out d);

            Fraction b = new Fraction(n, d);



            Console.WriteLine($"{a.Print()} ____ {b.Print()}");
            a.ToSimple();
            b.ToSimple();
            Console.WriteLine($"{a.Print()} ____ {b.Print()}");
            Fraction c =  Fraction.Sum(a, b);
            c.ToSimple();
            Console.WriteLine($"{a.Print()} + {b.Print()} = {c.Print()}");
            c = Fraction.Substract(a, b);
            c.ToSimple();
            Console.WriteLine($"{a.Print()} - {b.Print()} = {c.Print()}");
            c = Fraction.Mult(a, b);
            c.ToSimple();
            Console.WriteLine($"{a.Print()} * {b.Print()} = {c.Print()}");
            c = Fraction.Div(a, b);
            c.ToSimple();
            Console.WriteLine($"{a.Print()} : {b.Print()} = {c.Print()}");


            Helper.HomeWork.Pause();
        }
    }
}
