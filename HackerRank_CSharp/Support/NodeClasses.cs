using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Support
{
    class Node_Tree
    {
        public Node_Tree(int item)
        {
            Data = item;
            Left = null;
            Right = null;
        }

        public int       Data    { get; protected set; }
        public Node_Tree Left   { get; set; }
        public Node_Tree Right  { get; set; }

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
