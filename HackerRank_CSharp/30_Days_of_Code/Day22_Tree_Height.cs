using System;
using System.Collections.Generic;
using System.Text;
using HackerRank_CSharp.Support;

namespace HackerRank_CSharp._30_Days_of_Code
{

    class Day22_Tree_Height
    {

        public Node_Tree InsertTreeNode(Node_Tree node, int data)
        {
            if (node == null)
            {
                node = new Node_Tree(data);
            }

            else
            {
                Node_Tree current = null;

                if (data <= node.Key)
                {
                    current = InsertTreeNode(node.Left, data);
                    node.Left = current;
                }
                else
                {
                    current = InsertTreeNode(node.Right, data);
                    node.Right = current;
                }
            }

            return node;
        }

        public int GetHeight(Node_Tree node)
        {
            int height = 0;

            height = GetDepth(node) - 1;

            return height;
        }

        protected int GetDepth(Node_Tree node)
        {
            if (node == null)
                return 0;
            else
            {
                /* compute the depth of each subtree */
                int leftDepth = GetDepth(node.Left);
                int rightDepth = GetDepth(node.Right);

                int maxDepth = Math.Max(leftDepth, rightDepth);
                return maxDepth + 1;
            }
        }
    }
}
