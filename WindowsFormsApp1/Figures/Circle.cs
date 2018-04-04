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
        private int radius;
        private Point topLeft;

        public Circle(float fatness, Color color, Point topLeft, Point bottomRight) : base(fatness, color)
        {
            this.topLeft = topLeft;
            radius = bottomRight.X - topLeft.X;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, topLeft.X, topLeft.Y, radius, radius);
        }
    }
}
