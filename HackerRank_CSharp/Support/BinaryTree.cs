using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Support
{
    class BinaryTree
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

                if (data <= node.Data)
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

    }
}
