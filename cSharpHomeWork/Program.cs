using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpHomeWork
{
    class Program
    {
        //1. Пользователь вводит число секунд.Перевести секунды в часы, минуты, секунды.
        static void Main(string[] args)
        {
            //Console.Write("Введите количество времени в секундах: ");

            //int time = Convert.ToInt32(Console.ReadLine());
            //int hour = time / 3600;
            //int min = (time % 3600) / 60;
            //int sec = time % 60;
            //Console.WriteLine($" Часов: {hour} Минут: {min} Секунд: {sec}");

            //2. Пользователь вводит длину окружности L. Найти радиус такой окружности.

            Console.Write(" Введите длину окружности: ");
            double L = Convert.ToDouble(Console.ReadLine());
            double R = L / 3.14;
            Console.WriteLine($" Радиус равен: {R}");

            //3. Пользователь вводит трехзначное целое число. Найти сумму цифр данного числа.
            //Например, введено 123. Программа выводит сумму цифр = 6.

            //Console.Write("Введите трёхначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = (number % 10);
            //int temp = (number - (number % 10)) / 10;
            //sum = sum + (temp % 10);
            //sum = sum + (temp / 10);
            //Console.WriteLine($"Сумма цифр числа {number} равна: {sum}\n");
        }
    }
}