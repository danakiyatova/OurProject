using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите сторону a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите сторону b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите сторону c = ");
                double c = Convert.ToDouble(Console.ReadLine());
                double S;
                double p = (a + b + c) / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    Console.WriteLine("Сторона не может быть меньше или равной 0. Треугольник не существует.");
                }
                else if (a + b > c && a + c > b && b + c > a)
                {

                    Console.WriteLine("сумма двух сторон больше третьей - треугольник существует");
                    if (a == b && b == c && a == c)

                    {
                        Console.WriteLine("Равносторонний треугольник. Площадь: {0:f2}", S);

                    }

                    if (a == b || b == c || a == c)
                    {
                        Console.WriteLine("Равнобедренный треугольник. Площадь: {0:f2}", S);
                    }

                    if (a != b || b != c || a != c)
                    {
                        Console.WriteLine("Разносторонний треугольник. Площадь: {0:f2}", S);
                    }


                }
                else Console.WriteLine("сумма двух сторон меньше третьей - треугольник не существует");
                Console.ReadKey();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message + " Символы или пробелы недопустимы.");
                Console.ReadLine();
            }
        }
    }
}