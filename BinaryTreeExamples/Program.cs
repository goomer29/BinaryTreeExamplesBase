using System;
using DataStructureCore;
namespace BinaryTreeExamples
{
    class Program
    {
       
        static void Main(string[] args)
        {
          
          

            BinNode<int> root = new BinNode<int>(54);
            BinNode<int> left = new BinNode<int>(null, 77, new BinNode<int>(55));
            BinNode<int> right = new BinNode<int>(new BinNode<int>(63), 48, null);
            root.SetRight(right);
            root.SetLeft(left);
            Console.WriteLine("InOrder:");
            BTHelper.PrintInOrder(root);
            Console.WriteLine();
            Console.WriteLine("PreOrder:");
            BTHelper.PrintPreOrder(root);
            Console.WriteLine();
            Console.WriteLine("PostOrder:");
            BTHelper.PrintPostOrder(root);
            Console.WriteLine();

        }
    }
}
