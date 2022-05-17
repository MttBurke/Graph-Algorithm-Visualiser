using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Visualiser
{
    class Painter
    {

        private Pen p = new Pen(Color.Black);
        private int x, y = 0;
        private Graphics g = null;

        public Painter(Bitmap bitmap, Panel panel)
        {
            g = Graphics.FromImage(bitmap);
            x = panel.Width / 2;
        }

        public void DrawNode(Node inNode, int inDepth, int inX)
        {

            y = inDepth * 100;
            x = (inX * 100);
            g.DrawEllipse(p, x, y, 50, 50);

        }


    }
}
