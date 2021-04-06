using HackerRank_CSharp.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day24_LinkedList_RemoveDuplicateNode : BinaryTree
    {
        public Node_LinkedList RemoveDuplicateNodes(Node_LinkedList head)
        {
            var current  = head;
            int nodeData = current.Data;

            while (current.Next != null)
            {
                if (nodeData == current.Next.Data)
             
                {
                    var duplicate = current.Next;
                    current.Next  = duplicate.Next;
                    duplicate     = null;
                }
                else
                {
                    current  = current.Next;
                    nodeData = current.Data;
                }
            }
            return head;
        }
    }
}
