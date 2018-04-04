using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    class Curve : MyDraw
    {
        private Point[] curvePoints;

        public Curve(Point[] curvePoints)
        {
            this.curvePoints = curvePoints;
        }

        public override void Draw(Graphics graphics)
        {
            Pen myPen = new Pen(Color.Orange, 3.0F);
            graphics.DrawCurve(myPen, curvePoints);
        }
    }
}
