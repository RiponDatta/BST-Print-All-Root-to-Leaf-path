﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_All_Root_to_leaf
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(10);
            tree.Root.Left = new Node(8);
            tree.Root.Right = new Node(2);
            tree.Root.Left.Left = new Node(3);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(2);
            tree.Root.Right.Right = new Node(10);
            tree.Root.Right.Right.Right = new Node(16);

            tree.PrintPaths(tree.Root);
        }
    }

    public class Node
    {
        public int Data;
        public Node Left, Right;

        public Node(int data)
        {
            Data = data;
            Left = Right = null;
        }
    }

    public class BinaryTree
    {
        public Node Root;

        public void PrintPaths(Node root)
        {
            int height = Height(root);
            int[] path = new int[height];
            PrintPathRecursive(Root, path, 0);

        }

        private void PrintPathRecursive(Node root, int[] path, int pathLen)
        {
            if(root == null)
            {
                return;
            }

            path[pathLen] = root.Data;
            pathLen++;

            if(root.Left == null && root.Right == null)
            {
                PrintArray(path, pathLen);
            }
            else
            {
                PrintPathRecursive(root.Left, path, pathLen);
                PrintPathRecursive(root.Right, path, pathLen);
            }
        }

        private void PrintArray(int[] ints, int len)
        {
            int i;
            for (i = 0; i < len; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine("");
        }

        private int Height(Node root)
        {
            if(root == null)
            {
                return 0;
            }
            int l = Height(root.Left);
            int r = Height(root.Right);

            if(l > r)
            {
                return l + 1;
            }
            return r + 1;
        }
    }
}
