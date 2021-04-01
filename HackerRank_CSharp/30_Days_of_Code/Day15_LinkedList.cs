using HackerRank_CSharp.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day15_LinkedList
    {
        public Node_LinkedList Insert(Node_LinkedList head, int data)
        {
            Node_LinkedList nextNode = new Node_LinkedList(data);

            //Complete this method
            if (head != null)
            {
                Node_LinkedList tail = head;

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

        public string Display(Node_LinkedList head)
        {
            string          result  = String.Empty;
            Node_LinkedList            start   = head;
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
