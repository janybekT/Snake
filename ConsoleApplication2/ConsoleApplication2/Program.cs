using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Форматируем шапку программы
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************");
            Console.WriteLine("**** My Project ****");
            Console.WriteLine("********************");
            // Основная программа
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Hello, World!");

            // Ожидание нажатия клавиши Enter перед завершением работы
            Console.ReadLine();
        }
    }
}
