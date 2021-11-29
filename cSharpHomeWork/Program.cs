using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpHomeWork
{
    class Program
    {
        static void fillArr(int[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(2, 6);
                }
            }          
        }
        static void gradeBill(int[,] arr, int n)
        {
            Console.WriteLine($"\t Ведомость успеваемости по {n} предметам"); ;
            Console.Write("Math:        ");
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[0, i] != 0)
                    Console.Write(arr[0, i] + " ");
                else
                    break;
            }
            Console.WriteLine();
            Console.Write("Programming: ");
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[1, i] != 0)
                    Console.Write(arr[1, i] + " ");
                else
                    break;
            }
            Console.WriteLine();
            Console.Write("Philosophy:  ");
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[2, i] != 0)
                    Console.Write(arr[2, i] + " ");
                else
                    break;
            }
            Console.WriteLine();
            Console.Write("Physics:     ");
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[3, i] != 0)
                    Console.Write(arr[3, i] + " ");
                else
                    break;
            }
            Console.WriteLine();
            Console.Write("English:     ");
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[4, i] != 0)
                    Console.Write(arr[4, i] + " ");
                else
                    break;
            }
            Console.WriteLine("\n");
        }
        
        static int[,] gradeIn(int[,] arr, int m)
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[m, i] == 0)
                {
                    bool key = true;
                    do
                    {
                        Console.Write("\nВведите отметку (1-5): "); 
                        int grade = Convert.ToInt32(Console.ReadLine());
                        if (grade > 0 && grade < 6)
                        { 
                            arr[m, i] = grade;
                            key = false; 
                        }
                        else
                            Console.Write("\nПопробуйте ещё (1-5): ");
                        //key = true;
                    } while (key);
                    break;
                }
            }
            Console.WriteLine();
            return arr;
        }      
        static int themeAverage(int [,] arr, int m)
        {
            int average = 0, devide = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[m, i] != 0)
                    average += arr[m, i];                                     
                else
                {                  
                    break;
                }
                devide++;
            }
            average /= devide;
            return average;
        }
        static int allAverage(int[,] arr)
        {
            int average = 0, devider = 0;
            foreach (int elem in arr)
            {
                if (elem != 0)
                {
                    average += elem;
                    devider++;
                }
                else
                    continue;
            }
            average /= devider;
            return average;
        }
        static int maxGrade(int[,] arr)
        {
            int max = 0;
            foreach (int elem in arr)
            {
                if (elem > max)
                {
                    max = elem;                  
                }
                else
                    continue;
            }           
            return max;
        }
        static int minGrade(int[,] arr)
        {
            int min = 5;
            foreach (int elem in arr)
            {
                if (elem != 0)
                {
                    if (elem < min)
                        min = elem;
                }               
                else
                    continue;
            }
            return min;
        }

        static int themes()
        {
            Console.Clear();
            Console.WriteLine("\n\tВыберите предмет: \n");
            Console.WriteLine("1. Math:         - 1");
            Console.WriteLine("2. Programming:  - 2");
            Console.WriteLine("3. Philosophy:   - 3");
            Console.WriteLine("4. Physics:      - 4");
            Console.WriteLine("5. English       - 5\n");
            int key = Convert.ToInt32(Console.ReadLine());
            return key - 1;
        }

        static void Main(string[] args)
        {
            const int m = 5, n = 5;           
            int[,] gradeArr = new int[m, n]; // создали зубчатый массив           
            string[] Themes = new string[] { "Math", "Programming", "Philosophy", "Physics", "English" };                   
            int key = 0;
            do
            {
                Console.WriteLine("\tВыберите действие");
                Console.WriteLine("\n1. Выствить оценку по предмету (если есть свободные) --- 1");
                Console.WriteLine("2. Средний балл оценок по предмету --------------------- 2");
                Console.WriteLine("3. Средний балл по всем оценкам    --------------------- 3");
                Console.WriteLine("4. Поиск максимальной оценки       --------------------- 4");
                Console.WriteLine("5. Поиск минимальной оценки        --------------------- 5");
                Console.WriteLine("7. Рандомное заполнение ведомости  --------------------- 6");
                Console.WriteLine("7. Выход                           --------------------- 0\n");
                gradeBill(gradeArr, n);
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        gradeIn(gradeArr, themes());
                        break;
                    case 2:
                        int theme = themes();
                        Console.WriteLine($"Средняя оценка по {Themes[theme]}: " + themeAverage(gradeArr, theme));
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case 3:                      
                        Console.WriteLine($"Средняя оценка по предметам: " + allAverage(gradeArr));
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine($"Максимальная оценка по предметам: " + maxGrade(gradeArr));
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine($"Минимальная оценка по предметам: " + minGrade(gradeArr));
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case 6:
                        fillArr(gradeArr);
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (key !=0 );

            Console.WriteLine("Успехов в учёбе! ");           
        }
    }
}
