using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;
using System.Text;
using DataStructureCore;

namespace BinaryTreeExamples
{
    //כאן יופיעו כל הפעולות העזר עבור עצים
    class BTHelper
    {

        #region יצירת עץ
        public static BinNode<int> CreateTree()
        {
            BinNode<int> root;
            BinNode<int> left;
            BinNode<int> right;
            //קליטת הנתון
            int val = InputData();
            //אם נקלט null
            if (val == -1)
                return null;
            //אחרת צור את השורש
            root = new BinNode<int>(val);
            //צור את תת העץ השמאלי
            left = CreateTree();
            //צור את תת העץ הימני
            right = CreateTree();
            //חבר את תת העץ השמאלי לשורש
            root.SetLeft(left);
            //חבר את תת העץ הימני לשורש
            root.SetRight(right);
            //החזר את שורש תת העץ/שורש העץ
            return root;
        }

        /// <summary>
        /// פעולה היוצרת עץ רנדומלי בגובה
        /// height
        /// ערך כל צומת בטווח שבין max ל min
        /// </summary>
        /// <param name="height"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static BinNode<int> CreateRandomTree(int height, int min, int max)
        {
            Random rnd = new Random();
            BinNode<int> root;
            BinNode<int> left;
            BinNode<int> right;

            if (height == -1)
                return null;
            int val = rnd.Next(min, max + 1);
            root = new BinNode<int>(val);
            left = CreateRandomTree(height - 1, min, max);
            right = CreateRandomTree(height - 1, min, max);
            root.SetLeft(left);
            root.SetRight(right);
            return root;
        }

        private static int InputData()
        {
            Console.WriteLine("Please enter Value, enter -1 for null value (end Branch)");
            return int.Parse(Console.ReadLine());
        }


        #endregion


        #region סריקות
        #region סריקה תחילית
        /// <summary>
        /// פעולה המדפיסה עץ בינארי בסריקה תחילית
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        public static void PrintPreOrder<T>(BinNode<T> root)
        {
            if (root != null)
            {
                Console.WriteLine(root.GetValue());
                PrintPreOrder(root.GetLeft());
                PrintPreOrder(root.GetRight());
            }

        }
        #endregion

        #region סריקה תוכית
        /// <summary>
        /// פעולה המדפיסה עץ בינארי בסריקה תוכית
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        public static void PrintInOrder<T>(BinNode<T> root)
        {
            if (root != null)
            {
                PrintInOrder(root.GetLeft());
                Console.WriteLine(root.GetValue());
                PrintInOrder(root.GetRight());
            }

        }
        #endregion

        #region סריקה סופית
        /// <summary>
        /// פעולה המדפיסה עץ בינארי בסריקה סופית
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        public static void PrintPostOrder<T>(BinNode<T> root)
        {
            if (root != null)
            {
                PrintInOrder(root.GetLeft());
                PrintInOrder(root.GetRight());
                Console.WriteLine(root.GetValue());

            }

        }
        #endregion
        #endregion



        #region האם עלה
        public static bool IsLeaf<T>(BinNode<T> root)
        {
            return false;
        }
        #endregion


        #region פעולות על עצים
        #region ספירת צמתים
        /// <summary>
        /// פעולה המקבלת שורש של עץ ומחזירה את כמות הצמתים בעץ
        /// n- מספר הצמתים
        /// הפעולה מבקרת בכל צומת בדיוק פעם אחת
        /// ולכן O(n)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int CountTreeNodes<T>(BinNode<T> root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + CountTreeNodes(root.GetLeft()) + CountTreeNodes(root.GetRight());
        }
        #endregion

        #region האם ערך קיים בעץ
        public static bool IsExistsInTree<T>(BinNode<T> root, T val)
        {
            return false;

        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool EachHasTwoChilds<T>(BinNode<T> root)
        {
            return false;
        }

        /// <summary>
        /// עמ 176 שאלה 9 מהספר
        /// </summary>
        /// <param name="root"></param>
        public static void UpdateCharTree(BinNode<char> root)
        {


        }

        /// <summary>
        /// תרגיל 14
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>

        public static int CountLeaves<T>(BinNode<T> root)
        {
            return 0;

        }
        /// <summary>
        /// שאלה 12
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int CountBiggerInBetween(BinNode<double> root)
        {
            return 0;
        }

        #endregion


        #region גובה עץ
        /// <summary>
        /// פעולה המחשבת את גובה העץ בסריקה סופית
        /// גובה תת עץ שמאל, גובה תת עץ ימין ואז הגובה של העץ כולו הינו
        /// 1+ גובה המקסימלי מבין שני תתי העצים
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int BinTreeHight<T>(BinNode<T> root)
        {
            return 0;

        }
        #endregion

        #region הדפסת רמה בעץ

        #region פעולת המעטפת
        /// <summary>
        /// הדפסת הצמתים ברמה מסוימת בעץ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <param name="targetLevel"></param>
        public static void PrintNodesInLevel<T>(BinNode<T> root, int targetLevel)
        {

        }
        #endregion

        #region פעולת ההדפסה
        /// <summary>
        /// הפעולה תדפיס את ערך הצומת ברמה המבוקשת
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <param name="targetLevel">הרמה שנרצה להדפיס</param>
        /// <param name="currentLevel">הרמה הנוכחית שאליה הגענו בסריקה</param>
        private static void PrintNodesInLevel<T>(BinNode<T> root, int targetLevel, int currentLevel)
        {

        }
        #endregion
        #endregion

        #region חישוב רוחב של עץ

        #region פעולת ראשית
        /// <summary>
        /// פעולה מחשבת את רוחב העץ- הרמה שמכילה את הכי הרבה צמתים
        /// הפעולה תחזיר מערך בגודל 2 - בתא 0 יוחזר הרמה שמכילה את הכי הרבה צמתים
        /// ובתא 1 - הרוחב של העץ
        /// נגדיר h - גובה של העץ
        /// נגדיר n- כמות הצמתים בעץ
        /// CountNodesInLevel -  O(n)
        /// הפעולה מחשבת גובה ואז רצה בלולאה כגובה העץ ולכן נקבל
        /// 
        /// o(h)+(o(h) * O(n)).
        /// ==>(o(h) * O(n))
        /// במקרה הגרוע זה עץ שרשרת (כמו שרשרת חוליות רגילה)
        /// במקרה כזה 
        /// h==n
        /// ולכן
        /// O(n^2)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int[] BinTreeWidth<T>(BinNode<T> root)
        {

            return null;

        }
        #endregion


        #region פעולות עזר
        /// <summary>
        /// פעולת מעטפת המקבלת רמה בעץ ומחזירה כמה צמתים יש באותה רמה
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <param name="currentTreeLevel"></param>
        /// <returns></returns>
        private static int CountNodesInLevel<T>(BinNode<T> root, int currentTreeLevel)
        {
            //עץ ריק מקרה חריג
            if (root == null)
                return 0;
            //אנחנו צריכים לרדת בעץ לרמה המבוקשת ולכן צריך פעולת עזר שתעזור לנו להגיע לאותה רמה
            //נתחיל לחפש מהשורש של העץ 
            return CountNodesInLevel(root, currentTreeLevel, 0);
        }

        /// <summary>
        /// פעולה המקבלת שורש עץ, את הרמה שאליה נרצה להגיע והרמה הנוכחית בה אנו נמצאים
        /// הפעולה תחזיר את כמות הצמתים ברמה המבוקשת
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <param name="targetTreeLevel">הרמה המבוקשת</param>
        /// <param name="currentLevel"> הרמה הנוכחית בעץ</param>
        /// <returns></returns>
        private static int CountNodesInLevel<T>(BinNode<T> root, int targetTreeLevel, int currentLevel)
        {
            //אם בטעות עברנו את הרמה שאותה אנחנו מחפשים...
            if (currentLevel > targetTreeLevel)
                return -1;
            //מצב שלא אמור לקרות...
            if (root == null)
                return 0;
            //כאשר הגענו לרמה שחיפשנו
            if (targetTreeLevel == currentLevel)
                return 1;
            //אם לא הגענו לרמה שחיפשנו= נחזיר כמה צמתים יש בתת עץ שמאל ברמה שלנו + כמה יש בתת עץ ימין
            //ברמה שביקשנו
            return CountNodesInLevel(root.GetLeft(), targetTreeLevel, currentLevel + 1) + CountNodesInLevel(root.GetRight(), targetTreeLevel, currentLevel + 1);
        }
        #endregion

        #endregion

        #region חישוב רוחב של עץ באמצעות מערך מונים
        /// <summary>
        /// n= כמות הצמתים
        /// CountNodesInLevel- מבצעת סריקה אחת על העץ ולכן O(n)
        /// FindMax- במקרה של עץ שרשרת (כמו שרשרת חוליות)- O(n)
        /// ולכן קיבלנו
        /// O(n) + O(n)=O(n)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int[] BinTreeWidthVersion2<T>(BinNode<T> root)
        {
            return null;
        }


        #region פעולות עזר
        /// <summary>
        /// הפעולה מקבלת שורש עץ
        /// מערך מונים בגודל גובה העץ
        /// ורמה נוכחית
        /// הפעולה תוסיף 1 בתא המייצג את מספר הרמה בתהליך הסריקה
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <param name="treeLevels"></param>
        /// <param name="currentLevel"></param>
        private static void CountNodesInLevel<T>(BinNode<T> root, int[] treeLevels, int currentLevel)
        {
            if (root == null)
                return;
            treeLevels[currentLevel]++;
            CountNodesInLevel(root.GetLeft(), treeLevels, currentLevel + 1);
            CountNodesInLevel(root.GetRight(), treeLevels, currentLevel + 1);
        }

        /// <summary>
        /// מציאת מקסימום במערך.
        /// הפעולה מחזירה מערך בגודל 2
        /// תא הראשון המיקום של הערך המקסימלי
        /// והתא השני הערך המקסימלי במערך
        /// </summary>
        /// <param name="treeLevels"></param>
        /// <returns></returns>
        private static int[] FindMax(int[] treeLevels)
        {
            const int MAX_LEVEL_CELL = 0;
            const int MAX_WIDTH_CELL = 1;
            int[] maxWidth = new int[2];
            maxWidth[MAX_LEVEL_CELL] = 0;
            maxWidth[MAX_WIDTH_CELL] = 1;
            for (int i = 0; i < treeLevels.Length; i++)
            {
                if (treeLevels[i] > maxWidth[MAX_WIDTH_CELL])
                {
                    maxWidth[MAX_LEVEL_CELL] = i;
                    maxWidth[MAX_WIDTH_CELL] = treeLevels[i];
                }
            }
            return maxWidth;
        }
        #endregion
        #endregion

        #region Binary Search Tree

        #region הוספת ערך לעץ חיפוש
        public static void AddToBST(BinNode<int> t, int x)
        {


        }
        #endregion

        #region מקסימום/מינימום בעץ חיפוש
        public static int FindMaxInBST(BinNode<int> t)
        {
            return 0;
        }
        #endregion

        #region האם עץ חיפוש

        /// <summary>
        /// כל צומת צריך להיות גדול יותר מהכי גדול בתת העץ השמאלי שלו
        /// ויותר קטן מהכי קטן בתת עץ הימני שלו
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsBST(BinNode<int> t)
        {
            return false;

        }

        public static int FindMin(BinNode<int> t)
        {
            return 0;
        }
        #endregion

        #region מצא הורה בעץ חיפוש
        public static BinNode<int> FindParent(BinNode<int> root, BinNode<int> child)
        {
            return null;
        }
        #endregion

        #region מחיקת ערך בעץ חיפוש
        //            The node has no children(it's a leaf node). You can delete it. ...
        //The node has just one child.To delete the node, replace it with that child. ...
        //The node has two children.In this case, find the MAX in the LEFT Side of the node. (or MIN of the RIGHT SIDE OF THE NODE)

        public static BinNode<int> RemoveFromBST(BinNode<int> root, int key)
        {

            return null;

        }





        #endregion
        #endregion






    }  
}
