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
}
