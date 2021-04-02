using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day18_QueueStack
    {
        public Day18_QueueStack()
        {
            charQueue = new Queue<char>();
            charStack = new Stack<char>();
        }

        public void LoadData(string data)
        {
            charQueue.Clear();
            charStack.Clear();

            foreach(char ch in data)
            {
                Push(ch);
                Enqueue(ch);
            }
        }

        public bool IsPalidrome()
        {
            bool isPalindrome   = true;
            int length          = charQueue.Count;

            for (int i = 0; i < length / 2; i++)
            {
                char chQueue = Dequeue();
                char chStack = Pop();
                if (chQueue != chStack)
                {
                    isPalindrome = false;

                    break;
                }
            }

            return isPalindrome;
        }

        public void Push(char ch)
        {
            charStack.Push(ch);
        }

        public char Pop()
        {
            char ch;

            ch = charStack.Pop();

            return ch;
        }

        public void Enqueue(char ch)
        {
            charQueue.Enqueue(ch);
        }

        public char Dequeue()
        {
            char ch;

            ch = charQueue.Dequeue();

            return ch;
        }

        public Queue<char>  charQueue { get; protected set; }
        public Stack<char>  charStack { get; protected set; }

    }
}
