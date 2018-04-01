using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    class Circle : MyDraw
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw(PaintEventArgs e)
        {
            SolidBrush Brush = new SolidBrush(Color.Yellow);
            e.Graphics.FillEllipse(Brush, x, y, radius, radius);
        }
    }
}
