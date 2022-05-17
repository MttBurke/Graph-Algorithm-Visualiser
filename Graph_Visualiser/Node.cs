using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Visualiser
{
    class Node
    {

        int data;
        public Node left, right;

        public Node(int inData)
        {
            data = inData;
            left = right = null;
        }

    }

    class BinaryTree
    {

        public Node root;

        public  BinaryTree()
        {

        }

    }

}
