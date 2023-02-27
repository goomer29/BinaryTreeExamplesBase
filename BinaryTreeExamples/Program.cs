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
            BinNode<int> left = new BinNode<int>(new BinNode<int>(5), 77, new BinNode<int>(55));
            BinNode<int> right = new BinNode<int>(new BinNode<int>(63), 48, new BinNode<int>(34));
            root.SetRight(right);
            root.SetLeft(left);
            Console.WriteLine(Whidth<int>(root));

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
        public static int Whidth<T>(BinNode<T> root)
        {
            BinNode<T> node;
            Queue<BinNode<T>> queue = new Queue<BinNode<T>>();
            int level = 0;
            int maxrow = 0;
            int current = 0;
            int count = 0;
            int countmax = 0;
            Queue<int> levels = new Queue<int>();
            queue.Insert(root);
            levels.Insert(level);
            while (!queue.IsEmpty())
            {
                node = queue.Remove();
                level = levels.Remove();
                if (current == level)
                {
                    count++;
                }
                else
                {
                    if (count > countmax)
                    {
                        maxrow = current;
                        countmax = count;
                    }
                        current++;
                        count = 1;
                }
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
            if (count > countmax)
            {
                maxrow = current;
            }
            return maxrow;
        }
        // הסיבוכיות כאשר אין כמות העלים: O(n)
        public static int Whidth2<T>(BinNode<T> root)
        {
            int[] arr = new int[BTHelper.BinTreeHight(root)];
            BinNode<T> node;
            Queue<BinNode<T>> queue = new Queue<BinNode<T>>();
            Queue<int> levels = new Queue<int>();
            queue.Insert(root);
            int level = 0;
            levels.Insert(level);
            while (!queue.IsEmpty())
            {
                node = queue.Remove();
                level = levels.Remove();
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
                arr[level]++;
            }
            int maxcount = arr[0];
            int max = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                if (maxcount < arr[i])
                {
                    max = i;
                    maxcount = arr[i];
                }
            }
            return max;
        }
        public static BinNode<int> Putin(BinNode<int> root, int x)
        {
            if (root == null)
                return new BinNode<int>(x);
            if (root.GetValue() <= x)
            {
                root.SetRight(Putin(root.GetRight(),x));
            }
            else
            {
                root.SetLeft(Putin(root.GetLeft(),x));
            }
            return root;
        }
        public static bool IsBST(BinNode<int> root)
        {
            if (root == null)
            {
                return true;
            }
            if (root.HasRight())
            {
                if (root.GetRight().GetValue() < root.GetValue())
                    return false;
            }
            if (root.HasLeft())
            {
                if (root.GetLeft().GetValue() >= root.GetValue())
                    return false;
                return IsBST(root.GetRight());
            }
            return IsBST(root.GetRight())&&IsBST(root.GetLeft());
        }
    }
}
