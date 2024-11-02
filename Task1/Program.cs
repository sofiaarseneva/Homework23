using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Асинхронное программирование! Факториал числа!\n\n");
            try
            {
                Console.WriteLine("Введите число, факториал которого нужно найти:");
                int n = Convert.ToInt32(Console.ReadLine());
                GetFactorialAsync(n);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!" + ex.Message);
            }
            Console.ReadKey();
        }

        static void GetFactorial(int n)
        {
            long factorial = 1;

            if (n == 0)
            {
                Console.WriteLine("Факториал числа 0 равен 1.");
            }
            else if (n < 0)
            {
                Console.WriteLine("Введено отрицательное число!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"Факториал числа {n} равен {factorial}.");
            }
        }
        static async void GetFactorialAsync(int n)
        {
            await Task.Run(() => GetFactorial(n));
        }
    }
}
