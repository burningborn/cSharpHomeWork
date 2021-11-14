using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Реализовать программу решения квадратного уравнения. Пользователь вводит
            //коэффициенты a, b, c уравнения ax2 +bx + c = 0, программа выводит решение данного уравнения.

            //double a, b, c, D, x, x1, x2;

            //Console.Write("Введите значение a: ");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите значение b: ");
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите значение c: ");
            //c = Convert.ToDouble(Console.ReadLine());

            //D = (b * b) - 4 * a * c;
            //Console.WriteLine($"Дискриминант равен: {D}");
            //if (D > 0)
            //{
            //    x1 = (-b + Math.Sqrt(D)) / (2 * a);
            //    x2 = (-b - Math.Sqrt(D)) / (2 * a);
            //    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            //}
            //if (D < 0) 
            //{
            //    x = 0;
            //    Console.WriteLine("Уравнение не имеет корней!");
            //}
            //if(D==0)
            //{
            //    x = (-b + Math.Sqrt(D)) / (2 * a);
            //    Console.WriteLine($"x = {x}");
            //}

            //2. Реализовать программу разложения числа на простые множители. 
            //int number, denominator = 2; 
            //Console.Write("Введите число: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //Console.Write($"Простые множители числа {number}: ");
            //do
            //{
            //   if (number% denominator==0)
            //    {
            //        number = number / denominator;
            //        Console.Write($"{denominator} ");
            //    }
            //    else
            //    {
            //        denominator++;
            //    }
            //} while (number != 1);
            //Console.Write("\n");

            //3. Усовершенствовать программу проверки простого числа с урока следующим образом: теперь программа должна определять,
            //является ли число совершенным (число равно сумме своих делителей кроме него самого,
            //т.е. 6 = 1 + 2 + 3 = 1 * 2 * 3). Запустить алгоритм в цикле и указать, какие совершенные числа вы смогли отыскать.

            for (int number = 1; number <= 1000000; number++) // поиск совершенных чисел для чисел от 0 до 1000000
            {             
            int i = 0;
            int[] arr = new int[1000];   //массив для приёмамножителей
                //раскладываем число на множетели
                int denominator = 1;
                if(number != denominator)
                {
                    do
                    {
                        if (number % denominator == 0)
                        {                      
                                arr[i] = denominator;      //записываем множетели в массив
                                i++;                 
                        }                   
                                denominator++;            //увеличиваем делитель на единицу
                    } while (number != denominator);
                }
                arr[i] = 0;                         //в конце записываем ноль 
                int perfect = 0;                  //объявляем переменную для приёма суммы множителей
                i = 0;
                do
                {
                    perfect += arr[i];            //складываем делители
                    i++;
                } while (arr[i] != 0);

                if(number== perfect)            //если число равно сумме всех делителей
                Console.Write($"Число {number} является совершенным.\n");   //выводим его на экран             
            }
        }
    }
}
