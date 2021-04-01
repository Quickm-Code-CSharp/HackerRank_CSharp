using HackerRank_CSharp.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day23_Tree_LevelOrderTraversal : BinaryTree
    {
        public Day23_Tree_LevelOrderTraversal()
        {
            treeQueue = new Queue<Node_Tree>();
        }

        public string PrintLevelOrder(Node_Tree root)
        {
            string result = String.Empty;

            
            if (root != null)
            {
                treeQueue.Enqueue(root);
            
                while (treeQueue.Count != 0) {
                    Node_Tree tree = treeQueue.Dequeue();
                
                    Console.Write("{0} ", tree.Data);
                
                    if (tree.Left != null)
                    {
                        treeQueue.Enqueue(tree.Left);
                    }
                
                    if (tree.Right != null)
                    {
                        treeQueue.Enqueue(tree.Right);
                    }
                }
            }   
             
            return result;
        }

        public Queue<Node_Tree> treeQueue { get; protected set; }

    }
}
