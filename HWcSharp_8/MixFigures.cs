using System;
using System.Collections.Generic;
using System.Text;

namespace HWcSharp_8
{
    class MixFigures
    {
        double sSum = 0; //общая площадь
        double pSum = 0; //общий периметр

        Figures[] figuresArr;
        public MixFigures() // конструктор без параметров
        {
            figuresArr = new Figures[0];
        }
        public void addFigures(Figures figure) //метод добавления фигур
        {
            if (figuresArr == null)
            {
                figuresArr = new Figures[1] { figure }; //добавление в пустой объект
            }
            else
            {
                Figures[] temp_figuresArr = new Figures[figuresArr.Length + 1];  //создаем временный массив для хранения прежних значений
                figuresArr.CopyTo(temp_figuresArr, 0);                           //копируем исходный массив
                temp_figuresArr[temp_figuresArr.Length - 1] = figure;            //добавляем фигуру в конец списка
                figuresArr = temp_figuresArr;
            }
        }
        public double generalSquare()
        {
            
            foreach (var elem in figuresArr)
                sSum += elem.Square();
            return sSum;
        }
        public double generalPerimeter()
        {
            
            foreach (var elem in figuresArr)
                pSum += elem.Perimeter();
            return pSum;
        }

        public override string ToString()
        {    
            return $" Общая площадь фигур = {sSum}\n Общий периметр = {pSum}";
        }
    }
}
