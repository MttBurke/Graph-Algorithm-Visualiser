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
        }

    }
}
