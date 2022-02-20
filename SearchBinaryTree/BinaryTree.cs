using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SearchBinaryTree
{

    class BinaryTree<T> : IEnumerable<Node<T>> where T : IComparable<T>
    {
        //корень дерева
        public Node<T> root;
        //вспомогательный список узлов дерева в виде списка
        private List<Node<T>> nodesLinks;

        //вспомогательные свойства
        public int TreeSize { get { return nodesLinks.Count; } }

        //конструктор
        public BinaryTree()
        {
            root = null;
            nodesLinks = new List<Node<T>>();
        }

        //методы работы с деревом
        public void Add(T addValue) // метод добавления элемента
        {
            if (root == null) //если дерево пусто
            {
                root = new Node<T>(addValue); //создаём корень
                nodesLinks.Add(root);      //добавить корень в список вершин
            }
            else
            {
                //
                Node<T> addedNode = root.Add(addValue);
                nodesLinks.Add(addedNode); //добавляем новый узел в список 
            }
        }
        public Node<T> Search(Node<T> Root, T searchValue)// метод поиска узла по значению
        {
            if (Root == this.root || searchValue.CompareTo(Root.Value) == 0)
                return Root;
            if (searchValue.CompareTo(Root.Value) == -1)
                return Search(Root.Left, searchValue);
            else
                return Search(Root.Right, searchValue);
        }

        public Node<T> Min(Node<T> Root)   // метод поиска узла c минимальным значением
        {
            if (Root.Left == null)
                return Root;
            return Min(Root.Left);
        }
        public Node<T> Max(Node<T> Root)    // метод поиска узла c максимальным значением
        {
            if (Root.Right == null)
                return Root;
            return Max(Root.Right);
        }


        public Node<T> Remove(Node<T> root, T Removeble)
        {
            if (root == null) //если дерево пустое
            {
                Console.WriteLine("Дерево пустое!");
                return root;
            }

            if (root.Value.CompareTo(Removeble) > 0) // если значение удаляемого элемента меньше значения корня
            {
                root.Left = Remove(root.Left, Removeble); // идем в левое поддерево
            }
            else if (root.Value.CompareTo(Removeble) < 0) // если значение удаляемого элемента больше значения корня
            {
                root.Right = Remove(root.Right, Removeble);  // идем в правое поддерево
            }
            else if (root.Left != null && root.Right != null)  //если удаляемый элемент имеет два потомка 
            {
                root.Value = Min(root.Right).Value;    // приравниваем значение удаляемого элемента к минимальному значению правого поддерева
                root.Right = Remove(root.Right, root.Value);
            }
            else
                if (root.Left != null) //если удаляемый элемент имеет левого потомка 
                root = root.Left; // приравниваем удаляемый элемент к левому потомку
            else if (root.Right != null) //если удаляемый элемент имеет правого потомка
                root = root.Right;  // приравниваем удаляемый элемент к правому потомку
            else                    //если удаляемый элемент не имеет потомков (не является листом)
                root = null;       // приравниваем  его к null
            return root;
        }
        public override string ToString()
        {
            StringBuilder sB = new StringBuilder();
            root.ToString(sB, 0);
            return sB.ToString();
        }

        //автосгенерированные методы интерфейса IEnumerator
        public IEnumerator<Node<T>> GetEnumerator()
        {
            return ((IEnumerable<Node<T>>)nodesLinks).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)nodesLinks).GetEnumerator();
        }        
    }

}
