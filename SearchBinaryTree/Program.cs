using System;

namespace SearchBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Add(23);
            tree.Add(34);
            tree.Add(13);
            tree.Add(33);
            tree.Add(7);
            tree.Add(37);
            tree.Add(36);
            tree.Add(32);

            Console.WriteLine(tree);

            Console.WriteLine("Перебор всех узлов списка");
            foreach (Node<int> elem in tree)
            {
                Console.WriteLine(elem.Value);
            }

            tree.Remove(tree.root, 34);
            tree.Remove(tree.root, 13);
            tree.Remove(tree.root, 37);

            Console.WriteLine("Минимальный узел: - " + tree.Min(tree.root).Value);
            Console.WriteLine("Максимальный узел: - " + tree.Max(tree.root).Value);

            Console.WriteLine(tree);

        }
    }
}
