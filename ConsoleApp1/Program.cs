using System;
using ConsoleApp1;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsMath clsMath = new ClsMath();
            int[] data = { 3, 7, 1, 9, 4 };
            Console.WriteLine("Сумма: " + clsMath.sum(data));
            Console.WriteLine("Максимум: " + clsMath.max(data));
            Console.WriteLine("Минимум: " + clsMath.min(data));
            Console.WriteLine("Количество: " + clsMath.count(data));

        }
    }
}