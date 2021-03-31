using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Support
{
    class Node_Tree
    {
        public int Key;
        public Node_Tree Left;
        public Node_Tree Right;

        public Node_Tree(int item)
        {
            Key = item;
            Left = null;
            Right = null;
        }

    }

    class Node_LinkedList
    {
        public Node_LinkedList(int d)
        {
            Data = d;
            Next = null;
        }

        public int Data { get; protected set; }
        public Node_LinkedList Next { get; set; }

    };


}
