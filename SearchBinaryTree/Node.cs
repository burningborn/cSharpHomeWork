using System;
using System.Collections.Generic;
using System.Text;

namespace SearchBinaryTree
{
    //класс узла дерева
    //является genereics  
    //имеет ограничение 
    internal class Node<T> where T : IComparable<T>
    {
        //поля класса
        public T Value { get; set; }         //1. значение узла
        public Node<T> Left { get; set; }    //2. левая сторона
        public Node<T> Right { get; set; }   //3. правая сторона

        //конструкторы
        public Node(T value)
        {
            Value = value;
            Left = Right = null;
        }
      

        //методы для работы с деревом
        //1. рекурсивный метод доавления узла
        //принимает: добавляемое значение 
        //возвращает:  
        public Node<T> Add(T addValue)
        {
            if (Value.CompareTo(addValue) > 0) // добавляемое меньше текущего
            {
                //уйти влево 
                if (Left == null)
                {
                    //левого потомка нет
                    return Left = new Node<T>(addValue);
                }
                else
                {
                    //левый потомок есть
                    return Left.Add(addValue);
                }
            }
            else
            {
                //иначе вправо
                if (Right == null)
                {
                    //правого потомка нет
                    return Right = new Node<T>(addValue);
                }
                else
                {
                    //правый потомок есть
                    return Right.Add(addValue);
                }
            }
        }

        //2. рекурсивный метод вывода
        //вход: stringBuolder для сохранения результат ; offset 
        public void ToString(StringBuilder sB, int offset)
        {
            sB.Append(new string('\t', offset)); //отступ
            sB.Append($"({Value}\n");           //значение самого узла

            if (Right != null)
            {
                Right.ToString(sB, offset + 1);
            }
            else
            {
                sB.Append(new string('\t', offset)); //отступ
                sB.Append($"(Null\n");           //значение самого узла
            }
            if (Left != null)
            {
                Left.ToString(sB, offset + 1);
            }
            else
            {
                sB.Append(new string('\t', offset)); //отступ
                sB.Append($"(Null\n");           //значение самого узла
            }

            sB.Append(new string('\t', offset)); //отступ
            sB.Append(")\n");           //значение самого узла
        }
        public int CompareTo(Node<T> other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
