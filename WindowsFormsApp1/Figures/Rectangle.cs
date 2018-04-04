using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    class Rectangle : MyDraw
    {
        private Point topLeft, bottomRight;

        public Rectangle(float fatness, Color color, Point topLeft, Point bottomRight) : base(fatness, color)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, topLeft.X, topLeft.Y, bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y);
        }
    }
}
