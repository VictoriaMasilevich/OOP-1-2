using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    class Ellipse : MyDraw
    {
        private int x1, y1, x2, y2;

        public Ellipse(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void Draw(PaintEventArgs e)
        {
            SolidBrush Brush = new SolidBrush(Color.AliceBlue);
            e.Graphics.FillEllipse(Brush, x1, y1, x2, y2);
        }
    }
}
