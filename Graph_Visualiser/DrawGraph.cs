using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Visualiser
{
    class DrawGraph
    {

        BinaryTree tree = new BinaryTree();
        Bitmap bitmap;
        Painter painter;
        int x = 0;

        public DrawGraph(Bitmap inBitmap, Panel inPanel)
        {
            bitmap = inBitmap;
            painter = new Painter(bitmap, inPanel);

            tree.root = new Node(2);
            tree.root.left = new Node(1);
            tree.root.right = new Node(4);
            tree.root.right.left = new Node(3);
            tree.root.right.right = new Node(5);

            DrawTree(tree.root, 0);
        }

        public void DrawTree(Node inNode, int Depth)
        {
            if (inNode == null)
            {
                return;
            }

            DrawTree(inNode.left,Depth + 1);
            x += 1;
            painter.DrawNode(inNode, Depth, x);
            DrawTree(inNode.right, Depth + 1);

        }

    }
}
