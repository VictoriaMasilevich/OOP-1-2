using System.Collections.Generic;
using System.Drawing;

namespace Geometry
{
    public class ObjectsList
    {
        public List<Figure> myList = new List<Figure> { };
        Pen pen = new Pen(Color.RosyBrown, 3);
        int y1 = 10;
        int y2 = 50;

        public void Draw(Graphics g)
        {
            foreach (Figure myDraw in myList)
            {
                myDraw.Draw(g, pen, new Point(20, y1), new Point(80, y2));
                y1 += 70;
                y2 += 70;
            }
        }
    }
}