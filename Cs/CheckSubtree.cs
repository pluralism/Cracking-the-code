using System;

namespace ConsoleApp2
{
    public class CheckSubtree
    {
        public CheckSubtree() { }

        public void GetOrderString(TreeNode node, ref string s)
        {
            if(node == null)
            {
                s += "X";
                return;
            }

            // Pre-order traversal
            s += node.Data;
            GetOrderString(node.Left, ref s);
            GetOrderString(node.Right, ref s);
        }

        public void CheckTree(TreeNode tree1, TreeNode tree2)
        {
            string s1 = string.Empty;
            string s2 = string.Empty;

            GetOrderString(tree1, ref s1);
            GetOrderString(tree2, ref s2);
            Console.WriteLine(s1.Contains(s2));
        }
    }
}
