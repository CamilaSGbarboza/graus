using System;

namespace graus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("----GrausFC----");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("digite:");
            double f = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine();
            double c = (f - 32) / 1.8;
            Console.WriteLine($"{f} F equivalem a {c} C ");


        }
    }
}
