using System;
using DataStructureCore;
using System.ComponentModel.Design.Serialization;
using System.Text;
using System.Threading;
using System.Reflection.Emit;
using System.Drawing;

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
            WhichLevel(root, 2);
            Console.WriteLine();
            EvenLevels(root);
            Console.WriteLine(LevelsDistance(root,54,63));

        }
        public static void WhichLevel(BinNode<int> root, int level)
        {
            BinNode<int> node;
            Queue<BinNode<int>> queue = new Queue<BinNode<int>>();
            int count = 0;
            Queue<int> counts = new Queue<int>();
            queue.Insert(root);
            counts.Insert(count);
            while (!queue.IsEmpty()||count>level)
            {
                node = queue.Remove();
                count = counts.Remove();
                if (count == level)
                {
                    Console.Write(node.GetValue()+" ");
                }
                if (node.HasLeft())
                {
                    queue.Insert(node.GetLeft());
                    counts.Insert(count + 1);
                }
                if (node.HasRight())
                {
                    queue.Insert(node.GetRight());
                    counts.Insert(count + 1);
                }
            }
        }
        public static void EvenLevels(BinNode<int> root)
        {
            BinNode<int> node;
            Queue<BinNode<int>> queue= new Queue<BinNode<int>>();
            int count = 0;
            Queue<int> counts = new Queue<int>();
            queue.Insert(root);
            counts.Insert(count);
            while (!queue.IsEmpty())
            {
                node = queue.Remove();
                count = counts.Remove();
                if (count %2==0)
                {
                    Console.Write(node.GetValue() + " ");
                }
                if (node.HasRight())
                {
                    queue.Insert(node.GetRight());
                    counts.Insert(count + 1);
                }
                if (node.HasLeft())
                {
                    queue.Insert(node.GetLeft());
                    counts.Insert(count + 1);
                }
            }
            
        }
        public static int LevelsDistance(BinNode<int> root, int num1, int num2)
        {
            BinNode<int> node;
            Queue<BinNode<int>> queue = new Queue<BinNode<int>>();
            int level = 0;
            int level1 = 0;
            int level2 = 0;
            Queue<int> levels = new Queue<int>();
            queue.Insert(root);
            levels.Insert(level);
            while (!queue.IsEmpty())
            {
                node = queue.Remove();
                level = levels.Remove();
                if (node.GetValue() == num1)
                    level1 = level;
                if (node.GetValue() == num2)
                    level2 = level;
                if (node.HasLeft())
                {
                    queue.Insert(node.GetLeft());
                    levels.Insert(level + 1);
                }
                if (node.HasRight())
                {
                    queue.Insert(node.GetRight());
                    levels.Insert(level + 1);
                }
            }
            return Math.Abs(level2 - level1);
        }
    }
}
