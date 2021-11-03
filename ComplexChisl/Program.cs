using System;

namespace ComplexChisl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запишите число а для первого кмплексного числа");
            double a1 = 0;
            double.TryParse(Console.ReadLine(), out a1);
            Console.WriteLine("Запишите число b для первого кмплексного числа");
            double b1 = 0;
            double.TryParse(Console.ReadLine(), out b1);

            Complex chisl1 = new Complex(a1, b1);
            Console.WriteLine(chisl1);


            Console.WriteLine("Запишите число а для второго кмплексного числа");
            double a2 = 0;
            double.TryParse(Console.ReadLine(), out a2);
            Console.WriteLine("Запишите число b для второго кмплексного числа");
            double b2 = 0;
            double.TryParse(Console.ReadLine(), out b2);

            Complex chisl2 = new Complex(a2, b2);
            Console.WriteLine(chisl2);

            int y = 1;
            while (y != 0)
            {
                Complex chisl3;
                Console.WriteLine("Введите нужное вам действие(-;+;/;*;0 - выход с программы)");
                string vibor = Console.ReadLine();
                if (vibor == "+")
                {
                    chisl3 = chisl1 + chisl2;
                    Console.WriteLine("{0}", chisl3);
                }
                else if (vibor == "-")
                {
                    chisl3 = chisl1 - chisl2;
                    Console.WriteLine("{0}", chisl3);
                }
                else if (vibor == "*")
                {
                    chisl3 = chisl1 * chisl2;
                    Console.WriteLine("{0}", chisl3);
                }
                else if (vibor == "/")
                {
                    chisl3 = chisl1 / chisl2;
                    Console.WriteLine("{0}", chisl3);
                }
                else if (vibor == "0")
                {
                    y = 0;
                }
            }
        }
    }
}
