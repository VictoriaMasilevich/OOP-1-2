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

        public Curve(float fatness, Color color, Point[] curvePoints) : base(fatness, color)
        {
            this.curvePoints = curvePoints;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawCurve(pen, curvePoints);
        }
    }
}
