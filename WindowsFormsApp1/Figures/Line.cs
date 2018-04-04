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

        public Line(float fatness, Color color, Point topLeft, Point bottomRight) : base(fatness, color)
        {
            this.x1 = topLeft.X;
            this.y1 = topLeft.Y;
            this.x2 = bottomRight.X;
            this.y2 = bottomRight.Y;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
