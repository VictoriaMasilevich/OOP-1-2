using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    class Line : MyDraw
    {
        private int x1, y1, x2, y2;

        public Line(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void Draw(Graphics graphics)
        {
            Pen myPen = new Pen(Color.Red, 3.0F);
            graphics.DrawLine(myPen, x1, y1, x2, y2);
        }
    }
}
