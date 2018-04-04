using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace Geometry
{
    class Square : MyDraw
    {
        private Point topLeft;
        private int sidelength;
        public Square (float fatness, Color color, Point topLeft, Point bottomRight) : base(fatness, color)
        {
            this.topLeft = topLeft;
            this.sidelength = bottomRight.X - topLeft.X;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, topLeft.X, topLeft.Y, sidelength, sidelength);
        }
    }
}
