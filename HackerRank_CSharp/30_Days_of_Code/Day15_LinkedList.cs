using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Node
    {
        public Node(int d)
        {
            Data = d;
            Next = null;
        }

        public int Data { get;  protected set; }
        public Node Next { get;   set; }

    };
    class Day15_LinkedList
    {
        public Node Insert(Node head, int data)
        {
            Node nextNode = new Node(data);

            //Complete this method
            if (head != null)
            {
                Node tail = head;

                while (tail.Next != null)
                {
                    tail = tail.Next;
                }

                tail.Next = nextNode;
            }

            else
            {
                head = nextNode;
            }

            return head;
        }

        public string Display(Node head)
        {
            string          result  = String.Empty;
            Node            start   = head;
            StringBuilder   sb      = new StringBuilder();

            while (start != null)
            {
                sb.AppendFormat("{0} ", start.Data);
                start = start.Next;
            }

            result = sb.ToString();

            return result;
        }

    }
}
