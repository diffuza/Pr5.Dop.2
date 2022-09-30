using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Привет мир"; // присвоение локальной переменной "hello" строкового типа "string"
            Console.WriteLine(hello); // вывод на экран информации,которая присвоена локальной переменной "hello" 
            Console.WriteLine("Добро пожаловать в C#!"); // вывод "Добро пожаловать в C#!" на экран
            Console.WriteLine("Пока мир..."); // вывод "Пока мир..." на экран
            Console.WriteLine(24.5); // вывод на экран значения "24.5"
            Console.ReadKey(); // ожидание нажатия пользователем любой клавиши для закрытия консоли.
        }
    }
}
