using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    struct Complex
    {
        double im;
        double re;

       
        public Complex(double im, double re)
        {
            this.im = im;
            this.re = re;
        }
        public static Complex Plus(Complex a, Complex b)
        {
            return new Complex(a.im + b.im, a.re + b.re);
        }
        public static Complex Plus(ref Complex a,ref Complex b)
        {
            return new Complex(a.im + b.im, a.re + b.re);
        }
        public static Complex Subtract(Complex a, Complex b)
        {
            return new Complex(a.im - b.im, a.re - b.re);
        }
        public static Complex Subtract(ref Complex a, ref Complex b)
        {
            return new Complex(a.im - b.im, a.re - b.re);
        }
        public static Complex Mult(Complex a, Complex b)
        {
            return new Complex( (a.im * b.im)-(a.re*b.re) , ( (a.im*b.re) + (b.im*a.re) ) );
        }
        public static Complex Mult(ref Complex a,ref Complex b)
        {
            return new Complex((a.im * b.im) - (a.re * b.re), ((a.im * b.re) + (b.im * a.re)));
        }


        public void Print()
        {
            if(re<0)
            {
                Console.WriteLine($"{im}{re}i");
            }
            else
            {
                Console.WriteLine($"{im}+{re}i");
            }
        }

    }

    class ComplexClass
    {
        double im;
        double re;

        public ComplexClass()
        {
            this.im = 0;
            this.re = 0;
        }
        public ComplexClass(double im, double re)
        {
            this.im = im;
            this.re = re;
        }
        public static ComplexClass Plus(ComplexClass a, ComplexClass b)
        {
            return new ComplexClass(a.im + b.im, a.re + b.re);
        }
        public static ComplexClass Subtract(ComplexClass a, ComplexClass b)
        {
            return new ComplexClass(a.im - b.im, a.re - b.re);
        }
        public static ComplexClass Mult(ComplexClass a, ComplexClass b)
        {
            return new ComplexClass((a.im * b.im) - (a.re * b.re), ((a.im * b.re) + (b.im * a.re)));
        }


        public void Print()
        {
            if (re < 0)
            {
                Console.WriteLine($"{im}{re}i");
            }
            else
            {
                Console.WriteLine($"{im}+{re}i");
            }
        }

    }

    class Program
    {

       

        static void Main(string[] args)
        {
            Helper.HomeWork.PrintWelcomeMessage("3.1");
            Console.WriteLine(" а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса; ");
            Console.WriteLine();

            Console.Write("Введите вещественную часть первого числа : ");
            double a = 0;
            Double.TryParse(Console.ReadLine(),out a);
            Console.Write("Введите мнимую часть первого числа : ");
            double b = 0;
            Double.TryParse(Console.ReadLine(), out b);

            Console.Write("Введите вещественную часть второго числа : ");
            double a2 = 0;
            Double.TryParse(Console.ReadLine(), out a2);
            Console.Write("Введите мнимую часть второго числа : ");
            double b2 = 0;
            Double.TryParse(Console.ReadLine(), out b2);

            Console.WriteLine("С помощью структуры : ");


            Complex n = new Complex(a, b);
            Complex n2 = new Complex(a2, b2);
            Console.Write("Число 1 : ");
            n.Print();
            Console.Write("Число 2 : ");
            n2.Print();

            Console.Write("Сложение  = ");
            Complex.Plus(ref n,ref n2).Print();


            Console.Write("Вычитание = ");
            Complex.Subtract(ref n, ref n2).Print();

            Console.Write("Умножение = ");
            Complex.Mult(ref n, ref n2).Print();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("С помощью  класса : ");

            ComplexClass c_n = new ComplexClass(a, b);
            ComplexClass c_n2 = new ComplexClass(a2, b2);

            Console.Write("Число 1 : ");
            c_n.Print();
            Console.Write("Число 2 : ");
            c_n2.Print();

            Console.Write("Сложение  = ");
            ComplexClass.Plus(c_n, c_n2).Print();

            Console.Write("Вычитание = ");
            ComplexClass.Subtract(c_n, c_n2).Print();

            Console.Write("Умножение = ");
            ComplexClass.Mult(c_n, c_n2).Print();



            Helper.HomeWork.Pause();

        }
    }



}
