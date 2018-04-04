using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    abstract class MyDraw
    {
        public Color color;
        public float fatness;
        protected Pen pen;

        public MyDraw(float fatness, Color color)
        {
            this.fatness = fatness;
            this.color = color;
            pen = new Pen(color, fatness);
        }

        public abstract void Draw(Graphics graphics);
    }
}
