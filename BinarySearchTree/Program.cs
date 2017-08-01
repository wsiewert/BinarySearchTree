using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree(50);
            tree.Add(50);
            tree.Add(25);
            tree.Add(75);
            tree.Add(100);
            Console.WriteLine(tree.Find(24));
            Console.WriteLine(tree.Find(25));
            Console.WriteLine(tree.Find(100));
            Console.WriteLine(tree.Find(10000000));
            Console.ReadKey();
        }
    }
}
