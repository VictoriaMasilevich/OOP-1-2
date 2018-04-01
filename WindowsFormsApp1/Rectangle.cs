﻿using System;
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
        private int x, y, width, height;

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public override void Draw(PaintEventArgs e)
        {
            SolidBrush Brush = new SolidBrush(Color.SkyBlue);
            e.Graphics.FillRectangle(Brush, x, y, width, height);
        }
    }
}
