using System;

namespace SumDifMultDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите 1-е число: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите 2-е число: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nСумма: {a + b}\nРазница: {a - b}\nПроизведение: {a * b}\nЧастное: {a / b}\nОстаток от деления: {a % b}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            Console.ReadLine();
        }
    }
}