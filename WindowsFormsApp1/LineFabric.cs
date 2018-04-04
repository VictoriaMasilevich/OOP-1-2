using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry
{
    class LineFabric : Fabric
    {
        public override MyDraw FactoryMethod(float fatness, Color color, Point upperLeft, Point lowerRight)
        {
            return new Line(fatness, color, upperLeft, lowerRight);
        }
    }
}
