using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpHomeWork
{
    class Program
    {
        static void printArr(int [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   // Console.Write($"{arr[i, j]} ");
                    Console.Write("{2} ", i, j, arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int Average(int[,] arr)
        {
            int Average = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Average += arr[i, j];
                }
            }
            Average /= arr.Length;
            return Average;
        }

        
        static void Main(string[] args)
        {

            int[,] arr1, arr2, resArr  = null; // создали две матрицы

            Console.Write("Задайте количество столбцов матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Задайте количество строк матрицы: ");
            int m = Convert.ToInt32(Console.ReadLine());
            arr1 = new int[m, n]; // выделение памяти под первую матрицу
            arr2 = new int[m, n]; // выделение памяти под первую матрицу
            resArr = new int[m, n]; // выделение памяти под первую матрицу

            // инициализация элементов матриц
            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                for(int j=0;j<n; j++)
                {
                    arr1[i, j] = rand.Next(-99, 99);
                    arr2[i, j] = rand.Next(-99, 99);
                }

            }
            //вывод матрицы 1 на экран
            Console.WriteLine("Матрица_#1: ");
            printArr(arr1);
            // вывод матрицы 2 на экран
            Console.WriteLine("Матрица_#2: ");
            printArr(arr2);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resArr[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            Console.WriteLine("Сумма матриц: ");
            printArr(resArr);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resArr[i, j] = arr1[i, j] * arr2[i, j];
                }
            }
            Console.WriteLine("Произведение матриц: ");
            printArr(resArr);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resArr[i, j] = arr1[i, j] - arr2[i, j];
                }
            }
            Console.WriteLine("Разность матриц: ");
            printArr(resArr);
               
            Console.WriteLine($"Среднее арифметическое матрицы arr1: {Average(arr1)}");
            Console.WriteLine($"Среднее арифметическое матрицы arr2: {Average(arr2)}");
            Console.WriteLine($"Среднее арифметическое матрицы resArr: {Average(resArr)}");                   
        }
    }
}
