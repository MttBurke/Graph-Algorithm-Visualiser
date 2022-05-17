using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Visualiser
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
            GraphicsPanel.Size = new Size(this.Width, this.Height);
            bitmap = new Bitmap(GraphicsPanel.Width, GraphicsPanel.Height);
            DrawGraph drawGraph = new DrawGraph(bitmap, GraphicsPanel);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            GraphicsPanel.Size = new Size(this.Width, this.Height);
        }

        private void GraphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(bitmap, 0, 0);
        }
    }
}
